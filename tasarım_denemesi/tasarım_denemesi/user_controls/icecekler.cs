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
    public partial class icecekler : UserControl
    {
        public icecekler()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label3.Text.ToString());
            fatura_hesaplama a = new fatura_hesaplama(1.5);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label1.Text.ToString());
            fatura_hesaplama a = new fatura_hesaplama(2.0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label2.Text.ToString());
            fatura_hesaplama a = new fatura_hesaplama(1.0);
        }
    }
}
