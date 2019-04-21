using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace tasarım_denemesi
{
    public partial class aaaForm1 : Form
    {
        public aaaForm1()
        {
            InitializeComponent();
            doldur();
        }

        private void aaaForm1_Load(object sender, EventArgs e)
        {
            
        }

        void doldur()
        {
            veritabani_islemleri a = new veritabani_islemleri();
            DataTable tablo = a.verileri_ver();
            dataGridView1.DataSource = tablo;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_yonetici a = new frm_yonetici();
            a.Show();
            this.Dispose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                string veri = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string veri2 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                if (!veri.Trim().Equals(""))
                {
                    string[] alinanlar = veri.Split(',');
                    string[] alinanlar2 = veri2.Split(',');
                    string veriler = "";
                    veriler += "Yiyecekler:\n\n";
                    for (int i = 0; i < alinanlar.Length; i++)
                    {
                        veriler += alinanlar[i].Trim() + "\n";
                    }
                    veriler += "\n*********************\n";
                    veriler += "\nEkstralar:\n\n";
                    for (int i = 0; i < alinanlar2.Length; i++)
                    {
                        veriler += alinanlar2[i].Trim() + "\n";
                    }
                    MessageBox.Show(veriler);
                }
                
            }
        }

       
        public void ciro()
        {
            gizli a = new gizli();
            
            {

            }
            double toplam = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string veri = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                if (!veri.Equals(""))
                {
                    double sayi = Convert.ToDouble(veri);
                    toplam += sayi;
                }
            }
            MessageBox.Show("Toplam tutar: " + toplam);
        }

        private void bttn_musteri_giris_Click(object sender, EventArgs e)
        {

            gizli a = new gizli(0);
            a.Show();
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            gizli a = new gizli(1);
            a.Show();
        }
    }
        
        
    

       
}
