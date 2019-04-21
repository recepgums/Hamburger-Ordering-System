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
    public partial class dondurma : UserControl
    {
        public dondurma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(18.99);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle b= new klaslar.listeye_alinani_ekle(label2.Text.ToString());
            fatura_hesaplama a = new fatura_hesaplama(3.0);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle a = new klaslar.listeye_alinani_ekle(label6.Text.ToString());
            fatura_hesaplama b = new fatura_hesaplama(2.0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle a = new klaslar.listeye_alinani_ekle(label4.Text.ToString());
            fatura_hesaplama b = new fatura_hesaplama(2.0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle a = new klaslar.listeye_alinani_ekle(label5.Text.ToString());
            fatura_hesaplama b = new fatura_hesaplama(1.0);
        }
    }
}
