using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace tasarım_denemesi
{
    class veritabani_islemleri:baglanti 
    {
        public veritabani_islemleri()
        {
            
        }
        public  void butun_verileri_sil()
        {
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "delete *from tbl_siparis";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public bool siparis_kaydet(string isim, string tutar, string alinanlar,string eksta)
        {
            bool hata_yok = false;
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into tbl_siparis(siparis_isim,siparis_tutar,siparis_alinanlar,siparis_ekstra) values ('" + isim.Trim() + "','" + tutar.Trim() + "','" + alinanlar + "','" + eksta.Trim()+"')";
                cmd.ExecuteNonQuery();
                hata_yok = true;
            }
            catch (Exception) { }
            finally { con.Close(); }
            return hata_yok;
        }


        public DataTable verileri_ver()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                da = new OleDbDataAdapter("Select * from tbl_siparis", con);
                da.Fill(ds, "tbl_siparis");
            }
            catch (Exception) { }
            finally { con.Close(); }
            return ds.Tables["tbl_siparis"];
        }
        public bool giris(string kullanici_adi,string sifre)

        {
            bool sonuc = false;


            con.Open();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from calisan_giris where Kullanici_adi='" + kullanici_adi.Trim() + "' and Sifre='" + sifre.Trim() + "' and konum='yonetici'";
            OleDbDataReader oku;
            oku = cmd.ExecuteReader();

            if (oku.Read())
            {
                sonuc = true;

            }
            con.Close();
            return sonuc;
        }


    }
}
