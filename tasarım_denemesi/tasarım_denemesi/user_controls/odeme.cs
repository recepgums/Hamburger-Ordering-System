using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace tasarım_denemesi
{
    public partial class odeme : UserControl 
    {
        public OleDbConnection con;
        public OleDbDataAdapter da;
        public OleDbCommand cmd;
        public string soslar()
        {

            string eksta = "";
            if (checkBox1.Checked)
            {
                eksta += " " + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                eksta += " " + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                eksta += " " + checkBox3.Text;
            }
            if (radioButton1.Checked)
            {
                eksta += " " + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                eksta += radioButton2.Text;
            }
            return eksta;
        }
        public odeme()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void odeme_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            veritabani_islemleri islem = new veritabani_islemleri();

            if (a.Text.Trim() == "")
            {
                MessageBox.Show("İsim girmediniz");
            }
            else
            {
                string alinanlar = "";
                frm_musteri form = (frm_musteri)Application.OpenForms["frm_musteri"];
                ListBox lst = (ListBox)form.Controls.Find("lst_alınanlar", true)[0];
                for (int i = 0; i < lst.Items.Count; i++)
                {
                    alinanlar += lst.Items[i].ToString().Trim() + ",";
                }
                if (alinanlar.Contains(","))
                {
                    alinanlar = alinanlar.Substring(0, alinanlar.LastIndexOf(","));
                }
                string eksta = "";
                if (checkBox1.Checked)
                {
                    eksta += " , " + checkBox1.Text;
                }
                if (checkBox2.Checked)
                {
                    eksta += " , " + checkBox2.Text;
                }
                if (checkBox3.Checked)
                {
                    eksta += " ," + checkBox3.Text;
                }
                if (radioButton1.Checked)
                {
                    eksta += " , " + radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    eksta += " , "+radioButton2.Text;
                }
                if (eksta.Contains(","))
                {
                    eksta = eksta.Trim();
                    eksta = eksta.Substring(1);
                }
                bool kayit = islem.siparis_kaydet(a.Text, b.Text, alinanlar,eksta);
                if (kayit == true)
                {
                    MessageBox.Show("Siparişiniz verildi. Lütfen isminiz söylenene kadar bekleyiniz");
                    frm_musteri frm = (frm_musteri)Application.OpenForms["frm_musteri"];
                    frm.anasayfayi_ac();
                    frm.txt_hesap_goster.Clear();
                    a.Clear();
                    b.Clear();
                    lst_alınanlar.Items.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Teknik bir sıkıntı oluştu. Lütfen kasiyere haber veriniz");
                }
            

        }
    }

        private void odeme_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        
    }

    
        
    }

