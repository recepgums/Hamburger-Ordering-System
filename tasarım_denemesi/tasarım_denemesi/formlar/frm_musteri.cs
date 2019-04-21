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
    
    public partial class frm_musteri : Form
    {
        public double tutar = 0;
        public frm_musteri()
        {
            InitializeComponent();
            Sidepanel1.Height = bunifuImageButton5.Height;
            Sidepanel1.Top = bunifuImageButton5.Top;
            kullanıcı_kontol11.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_ana_menu a = new frm_ana_menu();
            a.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            Sidepanel1.Height = bunifuImageButton2.Height;
            Sidepanel1.Top = bunifuImageButton2.Top;
            dondurma1.BringToFront();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Sidepanel1.Height = bunifuImageButton1.Height;
            Sidepanel1.Top = bunifuImageButton1.Top;
          tatlılar1.BringToFront();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = bunifuImageButton4.Height;
            Sidepanel1.Top = bunifuImageButton4.Top+1;
            hamburgeruser1.BringToFront();
        }

        private void hamburgeruser1_Load(object sender, EventArgs e)
        {
        }

        public void anasayfayi_ac()
        {

            Sidepanel1.Height = bunifuImageButton5.Height;
            Sidepanel1.Top = bunifuImageButton5.Top;
            kullanıcı_kontol11.BringToFront();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            anasayfayi_ac();
        }

        private void Sidepanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hamburgeruser1_Load_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = bunifuImageButton3.Height;
            Sidepanel1.Top = bunifuImageButton3.Top;
            icecekler1.BringToFront();
            
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            odeme1.BringToFront();
            odeme1.b.Text = txt_hesap_goster.Text.ToString();
            
        }

        private void btn_toplam_fiyati_sil_Click(object sender, EventArgs e)
        {
            txt_hesap_goster.Clear();
            odeme1.b.Clear();
            odeme1.lst_alınanlar.Items.Clear();
            odeme1.a.Clear();
        }

        private void odeme1_Load(object sender, EventArgs e)
        {
            txt_hesap_goster.Clear();
            odeme1.b.Clear();
            odeme1.lst_alınanlar.Items.Clear();
            odeme1.a.Clear();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_ana_menu a = new frm_ana_menu();
            a.Show();
            this.Dispose();
        }

        private void txt_hesap_goster_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frm_ana_menu a = new frm_ana_menu();
            a.Show();
            this.Dispose();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton11_Click_1(object sender, EventArgs e)
        {
        }

        private void menu21_Load(object sender, EventArgs e)
        {

            
        }
        public int sayac = 0;
        private void bunifuImageButton11_Click_2(object sender, EventArgs e)
        {
            int sayac = 1;
            if (sayac%2==0)
            {
                kullanıcı_kontol11.BringToFront();
                sayac += 1;
            }
            else
            {
                menu21.BringToFront();
                sayac += 1;
            }
            
            
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            kullanıcı_kontol11.BringToFront();
        }
    }
}
