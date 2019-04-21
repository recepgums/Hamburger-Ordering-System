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
    public partial class kullanıcı_kontol1 : UserControl
    {
        public kullanıcı_kontol1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(20.0);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label1.Text.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

       

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(20.0);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label1.Text.ToString());

        }
    }
}
