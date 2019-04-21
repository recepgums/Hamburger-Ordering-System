using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasarım_denemesi
{
    public partial class Hamburgeruser : UserControl 
    {
        public double tutar = 0;
        
        public Hamburgeruser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            fatura_hesaplama a = new fatura_hesaplama(14.99);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label1.Text.ToString());
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void sandwitch_Click(object sender, EventArgs e)
        {
            fatura_hesaplama fiyat_ekle = new fatura_hesaplama(12.49);
            klaslar.listeye_alinani_ekle liste_ekleme_islemi = new klaslar.listeye_alinani_ekle(label4.Text.ToString());
        }

        private void angryburger_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(15.00);
            
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle( label18.Text.ToString());
        }

        private void xxlburger_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(18.99);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(xxl_burger.Text.ToString());
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(10.99);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(nuggetbruger.Text.ToString());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(16.49);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label12.Text.ToString());
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(20.00);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label6.Text.ToString());
        }

        private void suicideburger_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(22.49);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label20.Text.ToString());
        }

        private void Hamburgeruser_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
