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
    public partial class frm_yonetici : Form
    {
        public frm_yonetici()
        {
            InitializeComponent();
        }
        private void frm_yonetici_Load(object sender, EventArgs e)
        {
            
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            veritabani_islemleri a = new veritabani_islemleri();
            bool sonuc=a.giris(textBox1.Text,textBox2.Text);
            if (sonuc)
            {
                aaaForm1 b = new aaaForm1();
                b.Show();
                this.Hide();
            }
            else
            {
                bunifuCustomLabel1.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_ana_menu a = new frm_ana_menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
