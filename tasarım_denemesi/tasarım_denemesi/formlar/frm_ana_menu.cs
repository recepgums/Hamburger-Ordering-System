using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace tasarım_denemesi
{
    public partial class frm_ana_menu : Form
    {
        
        public frm_ana_menu()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void btn_musteri_giris_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_ana_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_yonetici_giris_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_yonetici_giris_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_musteri_giris_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_ana_menu a = new frm_ana_menu();
            a.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void bttn_calısan_giris_Click(object sender, EventArgs e)
        {
            frm_yonetici a = new frm_yonetici();
            a.Show();
            this.Hide();
        }

        private void bttn_musteri_giris_Click(object sender, EventArgs e)
        {
            frm_musteri a = new frm_musteri();
            a.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            saat_tarih.Text = Convert.ToString(DateTime.Now);
        }
    }
}
