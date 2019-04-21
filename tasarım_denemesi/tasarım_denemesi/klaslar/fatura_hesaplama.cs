using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasarım_denemesi
{
    class fatura_hesaplama
    {
        double eklenecek;
        public fatura_hesaplama(double eklenecek)
        {
            this.eklenecek = eklenecek;
            hesapla();
        }

        public void hesapla()
        {
            frm_musteri form = (frm_musteri)Application.OpenForms["frm_musteri"];
            TextBox txt = (TextBox)form.Controls.Find("txt_hesap_goster", true)[0];
            string veri = txt.Text;
            double toplam = 0;
            if (!veri.Trim().Equals(""))
            {
                double sayi = Convert.ToDouble(veri.Trim());
                toplam = sayi + eklenecek;
            }
            else
            {
                toplam = eklenecek;
            }
            txt.Text = toplam.ToString();
        }
    }
}
