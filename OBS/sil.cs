using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\6ncaf\OneDrive\Masaüstü\Ogrenci.mdb
namespace OBS
{
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\6ncaf\\OneDrive\\Masaüstü\\Ogrenci.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void onaylaButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Bilgiler where Okul_No ='" + silTextbox.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }
    }
}
