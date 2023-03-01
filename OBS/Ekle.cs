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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\6ncaf\\OneDrive\\Masaüstü\\Ogrenci.mdb");
        private void isim_Click(object sender, EventArgs e)
        {

        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Bilgiler (İsim, Soyisim ,Okul_No, Telefon, vize1, vize2) values ('" + isimTextBox.Text.ToString() + "', '" + soyisimTextBox.Text.ToString() + "','" + okulnoTextBox.Text.ToString() + "','" + telefonTextbox.Text.ToString() + "','" + vize1Textbox.Text.ToString() + "','" + vize2Textbox.Text.ToString() + "' )",baglanti);
            //OleDbCommand komut = new OleDbCommand("insert into Bilgiler (İsim, Soyisim ,Okul No, Telefon, vize1, vize2) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            //komut.Parameters.AddWithValue("@p1", isimTextBox.Text);
            //komut.Parameters.AddWithValue("@p2", soyisimTextBox.Text);
            //komut.Parameters.AddWithValue("@p3", okulnoTextBox.Text);
            //komut.Parameters.AddWithValue("@p4", telefonTextbox.Text);
            //komut.Parameters.AddWithValue("@p5", vize1Textbox.Text);
            //komut.Parameters.AddWithValue("@p6", vize2Textbox.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            Form1 ac = new Form1();
            ac.Show();
            Hide();
        }
    }
}
