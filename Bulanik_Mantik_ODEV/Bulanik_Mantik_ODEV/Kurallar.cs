using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulanik_Mantik_ODEV
{
    public class Kurallar
    {
        static public List<(int hassaslik,int miktar,int kirlilik,int donus_hizi,int sure,int deterjan_miktari)> kurallar = new List<(int,int,int,int,int,int)>();

        static int h_hassas = (int)Enumlar.Hassaslik.Hassas;
        static int h_orta = (int)Enumlar.Hassaslik.Orta;
        static int h_saglam = (int)Enumlar.Hassaslik.Saglam;

        static int m_kucuk = (int)Enumlar.Miktar.Kucuk;
        static int m_orta = (int)Enumlar.Miktar.Orta;
        static int m_buyuk= (int)Enumlar.Miktar.Buyuk;
        
        static int k_kucuk = (int)Enumlar.Kirlilik.Kucuk;
        static int k_orta = (int)Enumlar.Kirlilik.Orta;
        static int k_buyuk = (int)Enumlar.Kirlilik.Buyuk;

        static int do_hassas = (int)Enumlar.DonusHizi.Hassas;
        static int do_normalhassas = (int)Enumlar.DonusHizi.Normal_Hassas;
        static int do_orta = (int)Enumlar.DonusHizi.Orta;
        static  int do_normalguclu = (int)Enumlar.DonusHizi.Normal_Guclu;
        static int do_guclu = (int)Enumlar.DonusHizi.Guclu;

        static int s_kisa = (int)Enumlar.Sure.Kisa;
        static int s_normal_kisa = (int)Enumlar.Sure.Normal_Kisa;
        static int s_orta = (int)Enumlar.Sure.Orta;
        static  int s_normal_uzun = (int)Enumlar.Sure.Normal_Uzun;
        static int s_uzun = (int)Enumlar.Sure.Uzun;

        static int det_cokaz = (int)Enumlar.Deterjan_Miktari.Cok_Az;
        static int det_az = (int)Enumlar.Deterjan_Miktari.Az;
        static int det_orta = (int)Enumlar.Deterjan_Miktari.Orta;
        static int det_fazla = (int)Enumlar.Deterjan_Miktari.Fazla;
        static int det_cokfazla = (int)Enumlar.Deterjan_Miktari.Cok_Fazla;


        static public void Kurallari_Ata()
        {
            //1
            kurallar.Add((h_hassas, m_kucuk, k_kucuk, do_hassas, s_kisa, det_cokaz));
            //2
            kurallar.Add((h_hassas, m_kucuk, k_orta, do_normalhassas, s_kisa, det_az));
            //3
            kurallar.Add((h_hassas, m_kucuk, k_buyuk, do_orta, s_normal_kisa, det_orta));
            //4
            kurallar.Add((h_hassas, m_orta, k_kucuk, do_hassas, s_kisa, det_orta));
            //5
            kurallar.Add((h_hassas, m_orta, k_orta, do_normalhassas, s_normal_kisa, det_orta));
            //6
            kurallar.Add((h_hassas, m_orta, k_buyuk, do_orta, s_orta, det_fazla));
            //7
            kurallar.Add((h_hassas, m_buyuk, k_kucuk, do_normalhassas, s_normal_kisa, det_orta));
            //8
            kurallar.Add((h_hassas, m_buyuk, k_orta, do_normalhassas, s_orta, det_fazla));
            //9
            kurallar.Add((h_hassas, m_buyuk, k_buyuk, do_orta, s_normal_uzun, det_fazla));
            //10
            kurallar.Add((h_orta, m_kucuk, k_kucuk, do_normalhassas, s_normal_kisa, det_az));
            //11
            kurallar.Add((h_orta, m_kucuk, k_orta, do_orta, s_kisa, det_orta));
            //12
            kurallar.Add((h_orta, m_kucuk, k_buyuk, do_normalguclu, s_orta, det_fazla));
            //13
            kurallar.Add((h_orta, m_orta, k_kucuk, do_normalhassas, s_normal_kisa, det_orta));
            //14
            kurallar.Add((h_orta, m_orta, k_orta, do_orta, s_orta, det_orta));
            //15
            kurallar.Add((h_orta, m_orta, k_buyuk,do_hassas, s_uzun, det_fazla));
            //16
            kurallar.Add((h_orta, m_buyuk, k_kucuk, do_hassas, s_orta, det_orta));
            //17
            kurallar.Add((h_orta, m_buyuk, k_orta, do_hassas, s_normal_uzun, det_fazla));
            //18
            kurallar.Add((h_orta, m_buyuk, k_buyuk, do_hassas, s_uzun, det_cokfazla));
            //19
            kurallar.Add((h_saglam, m_kucuk, k_kucuk, do_orta, s_orta, det_az));
            //20
            kurallar.Add((h_saglam, m_kucuk, k_orta, do_normalguclu, s_orta, det_orta));
            //21
            kurallar.Add((h_saglam, m_kucuk, k_buyuk, do_guclu, s_normal_uzun, det_fazla));
            //22
            kurallar.Add((h_saglam, m_orta, k_kucuk, do_orta, s_orta, det_orta));
            //23
            kurallar.Add((h_saglam, m_orta, k_orta, do_normalguclu, s_normal_uzun, det_orta));
            //24
            kurallar.Add((h_saglam, m_orta, k_buyuk, do_guclu, s_orta, det_cokfazla));
            //25
            kurallar.Add((h_saglam, m_buyuk, k_kucuk, do_normalguclu, s_normal_uzun, det_fazla));
            //26
            kurallar.Add((h_saglam, m_buyuk, k_orta, do_normalguclu, s_uzun, det_fazla));
            //27
            kurallar.Add((h_saglam, m_buyuk, k_buyuk, do_guclu, s_uzun, det_cokfazla));
        }
    }
}
