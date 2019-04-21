using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasarım_denemesi
{
    public partial class gizli : Form
    {
        int ney_olsun;
        public gizli(int ney_olsun=0)
        {
            this.ney_olsun = ney_olsun;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            aaaForm1 a = (aaaForm1)Application.OpenForms["aaaForm1"];
            string sifre= "12345";
            if (textbox1.Text.Equals(sifre))
            {
                if (ney_olsun==0)
                {
                    double toplam = 0;
                    for (int i = 0; i < a.dataGridView1.RowCount; i++)
                    {
                        string veri = a.dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                        if (!veri.Equals(""))
                        {
                            double sayi = Convert.ToDouble(veri);
                            toplam += sayi;
                        }
                    }
                    MessageBox.Show("Toplam tutar: " + toplam);
                }else if (ney_olsun==1)
                {
                    DialogResult dialogResult = MessageBox.Show("Tüm siparişleri silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        veritabani_islemleri vt = new veritabani_islemleri();
                        vt.butun_verileri_sil();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
