using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace tasarım_denemesi
{
    class baglanti
    {
        public OleDbConnection con;
        public OleDbDataAdapter da;
        public OleDbCommand cmd;

        public baglanti()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=db.accdb");
        }
       
    }
}
