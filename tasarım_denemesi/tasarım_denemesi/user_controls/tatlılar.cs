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
    public partial class tatlılar : UserControl
    {
        public tatlılar()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(3.0);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label2.Text.ToString());
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            fatura_hesaplama a = new fatura_hesaplama(2.5);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label4.Text.ToString());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            fatura_hesaplama a = new fatura_hesaplama(1.0);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label3.Text.ToString());
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            fatura_hesaplama a = new fatura_hesaplama(1.0);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label1.Text.ToString());
        }
    }
}
