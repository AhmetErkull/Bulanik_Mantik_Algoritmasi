using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bulanik_Mantik_ODEV.Enumlar;

namespace Bulanik_Mantik_ODEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Column0", "Kural");
            dataGridView1.Columns.Add("Column1", "Hassaslık");
            dataGridView1.Columns.Add("Column2", "Miktar");
            dataGridView1.Columns.Add("Column3", "Kirlilik");
            dataGridView1.Columns.Add("Column4", "Dönüş Hızı");
            dataGridView1.Columns.Add("Column5", "Süre");
            dataGridView1.Columns.Add("Column6", "Deterjan Miktarı");

            Kurallar.Kurallari_Ata();
            int i = 1;
            foreach (var item in Kurallar.kurallar)
            {
                dataGridView1.Rows.Add(i++,(Enumlar.Hassaslik)item.Item1,(Enumlar.Miktar)item.Item2,(Enumlar.Kirlilik)item.Item3,(Enumlar.DonusHizi)item.Item4,(Enumlar.Sure)item.Item5,(Enumlar.Deterjan_Miktari)item.Item6);
            }
            dataGridView1.ClearSelection();

        }


        private void btn_isle_Click(object sender, EventArgs e)
        {
            lbl_hassaslikkume.Text = string.Empty;
            lbl_miktarkume.Text = string.Empty;
            lbl_kirlilikkume.Text = string.Empty;
            Algoritma a = new Algoritma(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
            foreach (var item in a.HassaslikKumeler)
            {
                Hassaslik[] dizi = (Hassaslik[])Enum.GetValues(typeof(Hassaslik));
                lbl_hassaslikkume.Text += dizi[item].ToString() + ",";
            }
            lbl_hassaslikkume.Text = lbl_hassaslikkume.Text.TrimEnd(',');
            foreach (var item in a.MiktarKumeler)
            {
                Miktar[] dizi = (Miktar[])Enum.GetValues(typeof(Miktar));
                lbl_miktarkume.Text += dizi[item].ToString() + ",";
            }
            lbl_miktarkume.Text = lbl_miktarkume.Text.TrimEnd(',');
            foreach (var item in a.KirlilikKumeler)
            {
                Kirlilik[] dizi = (Kirlilik[])Enum.GetValues(typeof(Kirlilik));
                lbl_kirlilikkume.Text += dizi[item].ToString() + ",";
            }
            lbl_kirlilikkume.Text = lbl_kirlilikkume.Text.TrimEnd(',');

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                int rowNumber = row.Index;


                if (a.TetiklenenKurallarList.Contains(rowNumber))
                {
                    row.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }
            listBox1.Items.Clear();
            foreach (var item in a.kuralmin)
            {
                listBox1.Items.Add(item.mindeger);
            }

            lbl_donushizi.Text = a.DonusHiziCiktisi.ToString();
            lbl_sure.Text = a.SureCiktisi.ToString();
            lnl_deterjanmiktari.Text = a.DeterjanMiktariCiktisi.ToString();


        }
    }
}
