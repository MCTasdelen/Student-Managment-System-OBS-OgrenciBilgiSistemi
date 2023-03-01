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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\6ncaf\\OneDrive\\Masaüstü\\Ogrenci.mdb");
        private void verigoruntule()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Bilgiler");
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                
                ekle.Text = oku["İsim"].ToString();
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["Okul_No"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["vize1"].ToString());
                ekle.SubItems.Add(oku["vize2"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kaydiGoster_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verigoruntule();
        }

        private void yeniKayit_Click(object sender, EventArgs e)
        {
            Ekle cagir = new Ekle();
            cagir.Show();
            Hide();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            sil cagir = new sil();
            cagir.ShowDialog();
            

        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            Guncel cagir = new Guncel();
            cagir.Show();
            Hide();
        }
    }
}
