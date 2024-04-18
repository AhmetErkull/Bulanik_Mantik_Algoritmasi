using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulanik_Mantik_ODEV
{
    public class Algoritma
    {
        private double _hassaslikDeger;
        private double _miktarDeger;
        private double _kirlilikDeger;
        private readonly double[] _donusHiziOrtaDegerler = { 0.5, 2.75, 5, 7.25, 9.5 };
        private readonly double[] _sureOrtaDegerler = { 22.3, 39.9, 57.5, 75.1, 92.7 };
        private readonly double[] _deterjanMiktariOrtaDegerler = { 20, 85, 150, 215, 280 };
        private List<int> _hassaslikKumeler = new List<int>();
        private List<int> _miktarKumeler = new List<int>();
        private List<int> _kirlilikKumeler = new List<int>();
        private List<int> _tetiklenenKurallarList = new List<int>();

        public double DonusHiziCiktisi { get; private set; }
        public double SureCiktisi { get; private set; }
        public double DeterjanMiktariCiktisi { get; private set; }
        public List<int> HassaslikKumeler { get => _hassaslikKumeler; set => _hassaslikKumeler = value; }
        public List<int> MiktarKumeler { get => _miktarKumeler; set => _miktarKumeler = value; }
        public List<int> KirlilikKumeler { get => _kirlilikKumeler; set => _kirlilikKumeler = value; }
        public List<int> TetiklenenKurallarList { get => _tetiklenenKurallarList; set => _tetiklenenKurallarList = value; }

        public Algoritma(double hassaslikDeger, double miktarDeger, double kirlilikDeger)
        {
            _hassaslikDeger = hassaslikDeger;
            _miktarDeger = miktarDeger;
            _kirlilikDeger = kirlilikDeger;
            Uygula();
        }

        public void Kumeleri_Belirle()
        {
            if (Girdi_Uyelik_Araligi(_hassaslikDeger, 0, 4))
                _hassaslikKumeler.Add((int)Enumlar.Hassaslik.Saglam);
            if (Girdi_Uyelik_Araligi(_hassaslikDeger, 3, 7))
                _hassaslikKumeler.Add((int)Enumlar.Hassaslik.Orta);
            if (Girdi_Uyelik_Araligi(_hassaslikDeger, 5.5, 10))
                _hassaslikKumeler.Add((int)Enumlar.Hassaslik.Hassas);

            if (Girdi_Uyelik_Araligi(_miktarDeger, 0, 4))
                _miktarKumeler.Add((int)Enumlar.Miktar.Kucuk);
            if (Girdi_Uyelik_Araligi(_miktarDeger, 3, 7))
                _miktarKumeler.Add((int)Enumlar.Miktar.Orta);
            if (Girdi_Uyelik_Araligi(_miktarDeger, 5.5, 10))
                _miktarKumeler.Add((int)Enumlar.Miktar.Buyuk);

            if (Girdi_Uyelik_Araligi(_kirlilikDeger, 0, 4.5))
                _kirlilikKumeler.Add((int)Enumlar.Kirlilik.Kucuk);
            if (Girdi_Uyelik_Araligi(_kirlilikDeger, 3, 7))
                _kirlilikKumeler.Add((int)Enumlar.Kirlilik.Orta);
            if (Girdi_Uyelik_Araligi(_kirlilikDeger, 5.5, 10))
                _kirlilikKumeler.Add((int)Enumlar.Kirlilik.Buyuk);
        }

        public bool Girdi_Uyelik_Araligi(double deger, double min, double max)
        {
            return deger >= min && deger <= max;
        }
        public double Fonksiyon(double deger,int kume, bool kirlilik=false)
        {
            if (kume == 0)
            {
                if (!kirlilik)
                {
                    if (deger <= 2)
                        return 1;
                    else
                        return 1 - ((deger - 2) / 2);
                }
                else
                {
                    if (deger <= 2)
                        return 1;
                    else
                        return 1 - ((deger - 2) / 2.5);
                }
                
            }
            if (kume == 1)
            {
                if (deger <= 5)
                    return (deger - 3) / 2;
                else
                    return 1-((deger - 5) / 2);
            }
            if (kume == 2)
            {
                if (deger >= 8)
                    return 1;
                else
                    return 1-((8- deger) / 2.5);
            }
            return -1;
        }
        public void Tetiklenen_Kurallar()
        {
            for (int i = 0; i < _hassaslikKumeler.Count; i++)
            {
                for (int j = 0; j < _miktarKumeler.Count; j++)
                {
                    for (int x = 0; x < _kirlilikKumeler.Count; x++)
                    {
                        TetiklenenKurallarList.Add((18-9 * _hassaslikKumeler[i]) + 3 * _miktarKumeler[j] + _kirlilikKumeler[x]);
                    }
                }
            }
        }
        public double MamdaniMin(params double[] sayilar)
        {
            return sayilar.Min();
        }
        public double MamdaniMax(params double[] sayilar)
        {
            return sayilar.Max();
        }

        public void Uygula()
        {
            Kumeleri_Belirle();
            Tetiklenen_Kurallar();
            MamdaniGirdi();
            MamdaniCikti();
        }

        public List<(int kural, double mindeger)> kuralmin = new List<(int kural, double mindeger)>();
        public void MamdaniGirdi()
        {
            foreach (var kural in TetiklenenKurallarList)
            {
                double hassaslik_uyelikd= Fonksiyon(_hassaslikDeger, Kurallar.kurallar[kural].hassaslik);
                double miktar_uyelikd = Fonksiyon(_miktarDeger, Kurallar.kurallar[kural].miktar);
                double kirlilik_uyelikd = Fonksiyon(_kirlilikDeger, Kurallar.kurallar[kural].kirlilik,true);
                double min = MamdaniMin(hassaslik_uyelikd, miktar_uyelikd, kirlilik_uyelikd);
                kuralmin.Add((kural, min));
            }
        }

        public void MamdaniCikti()
        {
            var grupdonushizi = kuralmin.GroupBy(i => Kurallar.kurallar[i.kural].donus_hizi);
            var grupsure = kuralmin.GroupBy(i => Kurallar.kurallar[i.kural].sure);
            var grupdeterjanmiktari = kuralmin.GroupBy(i => Kurallar.kurallar[i.kural].deterjan_miktari);
            List<(int kural,double deger)> maxlistdonushizi = new List<(int, double)>();
            List<(int kural,double deger)> maxlistsure = new List<(int, double)>();
            List<(int kural,double deger)> maxlistdeterjanmiktari = new List<(int, double)>();
            foreach (var item in grupdonushizi)
            {
                double maxdeger = MamdaniMax(item.Select(x => x.mindeger).ToArray());
                int kural = Kurallar.kurallar[(item.Select(x => x.kural).ToArray()[0])].donus_hizi;
                maxlistdonushizi.Add((kural, maxdeger));

            }
            foreach (var item in grupsure)
            {
                double maxdeger = MamdaniMax(item.Select(x => x.mindeger).ToArray());
                int kural = Kurallar.kurallar[(item.Select(x => x.kural).ToArray()[0])].sure;
                maxlistsure.Add((kural, maxdeger));

            }
            foreach (var item in grupdeterjanmiktari)
            {
                double maxdeger = MamdaniMax(item.Select(x => x.mindeger).ToArray());
                int kural = Kurallar.kurallar[(item.Select(x => x.kural).ToArray()[0])].deterjan_miktari;
                maxlistdeterjanmiktari.Add((kural, maxdeger));
            }

            DonusHiziCiktisi = Agirlikli_Ortalama(maxlistdonushizi, "dönüş hızı");
            SureCiktisi = Agirlikli_Ortalama(maxlistsure, "süre");
            DeterjanMiktariCiktisi = Agirlikli_Ortalama(maxlistdeterjanmiktari, "deterjan miktarı");

        }
        public double Agirlikli_Ortalama(List<(int kural,double deger)> maxlist, string kural)
        {
            List<double> pay = new List<double>();
            double payda = 0;
            if (kural == "dönüş hızı")
            {
                for (int i = 0; i < maxlist.Count; i++)
                {
                    double deger = maxlist[i].deger;
                    double carpan = _donusHiziOrtaDegerler[maxlist[i].kural];
                    pay.Add(deger*carpan);
                    payda += maxlist[i].deger;
                }
            }
            else if (kural == "süre")
            {
                for (int i = 0; i < maxlist.Count; i++)
                {
                    double deger = maxlist[i].deger;
                    double carpan = _sureOrtaDegerler[maxlist[i].kural];
                    pay.Add(deger * carpan);
                    payda += maxlist[i].deger;
                }
            }
            else if (kural == "deterjan miktarı")
            {
                for (int i = 0; i < maxlist.Count; i++)
                {
                    double deger = maxlist[i].deger;
                    double carpan = _deterjanMiktariOrtaDegerler[maxlist[i].kural];
                    pay.Add(deger * carpan);
                    payda += maxlist[i].deger;
                }
            }
            return (pay.Sum()/payda);
           
        }
     
    }
}

