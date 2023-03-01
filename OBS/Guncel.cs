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
    public partial class Guncel : Form
    {
        public Guncel()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\6ncaf\\OneDrive\\Masaüstü\\Ogrenci.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void Guncel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciDataSet.Bilgiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bilgilerTableAdapter.Fill(this.ogrenciDataSet.Bilgiler);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="İsim")
            {
                if(newnameLabel.Visible && isimtextBox.Visible && isimButton.Visible)
                {
                    newnameLabel.Visible = false;
                    isimtextBox.Visible = false;
                    isimButton.Visible = false;
                }
                else
                {
                    newnameLabel.Visible = true;
                    isimtextBox.Visible = true;
                    isimButton.Visible = true;
                }

            }
            else if(comboBox1.Text=="Soyisim")
            {
                if(newsurnamekabel.Visible && soyisimtextBox.Visible && soyisimButton.Visible)
                {
                    newsurnamekabel.Visible = false;
                    soyisimtextBox.Visible = false;
                    soyisimButton.Visible = false;

                }
                else
                {
                    soyisimtextBox.Visible = true;
                    newsurnamekabel.Visible = true;
                    soyisimButton.Visible = true;
                }
            }
            else if(comboBox1.Text=="Telefon")
            {
                if(newtelLabel.Visible && telnotextBox.Visible && telnoButton.Visible)
                {
                    newtelLabel.Visible = false;
                    telnotextBox.Visible = false;
                    telnoButton.Visible = false;
                }
                else
                {
                    telnotextBox.Visible = true;
                    newtelLabel.Visible = true;
                    telnoButton.Visible = true;
                }
            }
            else if(comboBox1.Text=="Vize1")
            {
                if(newvize1Label.Visible && vize1textBox.Visible && vize1Button.Visible)
                {
                    newvize1Label.Visible = false;
                    vize1textBox.Visible = false;
                    vize1Button.Visible = false;
                }
                else
                {
                    vize1textBox.Visible = true;
                    newvize1Label.Visible = true;
                    vize1Button.Visible = true;
                }
            }
            else
            {
                if(newvize2Label.Visible && vize2textBox.Visible && vize2Button.Visible)
                {
                    newvize2Label.Visible = false;
                    vize2textBox.Visible = false;
                    vize2Button.Visible = false;
                }
                else
                {
                    vize2textBox.Visible = true;
                    newvize2Label.Visible = true;
                    vize2Button.Visible = true;
                }
            }
        }
        //komut.CommandText = "update Bilgiler set İsim = '" + isimtextBox.Text + "', Soyisim='" + soyisimtextBox.Text + "', Telefon= '" + telnotextBox.Text + "', vize1='" + vize1textBox.Text + "', vize2='" + vize2textBox.Text + "' where Okul_No='" + NotextBox.Text + "'";
        private void OnaylaButton_Click(object sender, EventArgs e)
        {
           // baglanti.Open();
           // komut.Connection = baglanti;

           //if(comboBox1.Text=="İsim")
           // {
           //     komut.CommandText = " update Bilgiler set İsim='" + isimtextBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
           //     komut.ExecuteNonQuery();
           // }
           //if(comboBox1.Text=="Soyisim")
           // {
           //     komut.CommandText = "update Bilgiler set Soyisim='" + soyisimtextBox.Text + "' where Okul_No='" + NotextBox.Text + "'";
           //     komut.ExecuteNonQuery();
           // }
           //if(comboBox1.Text=="Telefon")
           // {
           //     komut.CommandText = "update Bilgiler set Telefon='" + telnotextBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
           //     komut.ExecuteNonQuery();
           // }
           //if(comboBox1.Text=="Vize1")
           // {
           //     komut.CommandText="update Bilgiler set vize1='"+vize1textBox.Text+ "' where  Okul_No='" + NotextBox.Text + "'";
           //     komut.ExecuteNonQuery();
           // }
           // if (comboBox1.Text == "Vize2")
           // {
           //     komut.CommandText = "update Bilgiler set vize2='" + vize2textBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
           //     komut.ExecuteNonQuery();
           // }

           // baglanti.Close();
            Form1 cagir = new Form1();
            cagir.Show();
            this.Close();
        }

        private void isimButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = " update Bilgiler set İsim='" + isimtextBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
            komut.ExecuteNonQuery();

            baglanti.Close();

        }

        private void soyisimButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set Soyisim='" + soyisimtextBox.Text + "' where Okul_No='" + NotextBox.Text + "'";
                komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void telnoButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set Telefon='" + telnotextBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
                komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void vize1Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set vize1='" + vize1textBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void vize2Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set vize2='" + vize2textBox.Text + "' where  Okul_No='" + NotextBox.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
