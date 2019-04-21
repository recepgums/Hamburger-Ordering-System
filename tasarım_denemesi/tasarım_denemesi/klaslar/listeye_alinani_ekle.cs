using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasarım_denemesi.klaslar
{
    class listeye_alinani_ekle
    {
        string eklenecek;
        public listeye_alinani_ekle(string eklenecek)
        {
            this.eklenecek = eklenecek;
            listeye_ekle();
        }
        public void listeye_ekle()
        {
            frm_musteri form = (frm_musteri)Application.OpenForms["frm_musteri"];
            ListBox lst = (ListBox)form.Controls.Find("lst_alınanlar", true)[0];
            lst.Items.Add(eklenecek);
        }
    }
}
