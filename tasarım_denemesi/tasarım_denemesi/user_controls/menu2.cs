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
    public partial class menu2 : UserControl
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menu2_Load(object sender, EventArgs e)
        {
            kullanıcı_kontol1 a = new kullanıcı_kontol1();
            a.BringToFront();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            kullanıcı_kontol1 a = new kullanıcı_kontol1();
            a.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            fatura_hesaplama a = new fatura_hesaplama(22.00);
            klaslar.listeye_alinani_ekle b = new klaslar.listeye_alinani_ekle(label1.Text.ToString());
        }
    }
}
