
namespace OBS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kaydiGoster = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.İsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OkulNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vize1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vize2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yeniKayit = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kaydiGoster
            // 
            this.kaydiGoster.BackColor = System.Drawing.Color.SandyBrown;
            this.kaydiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydiGoster.Location = new System.Drawing.Point(31, 23);
            this.kaydiGoster.Name = "kaydiGoster";
            this.kaydiGoster.Size = new System.Drawing.Size(140, 80);
            this.kaydiGoster.TabIndex = 0;
            this.kaydiGoster.Text = "Kaydı Göster";
            this.kaydiGoster.UseVisualStyleBackColor = false;
            this.kaydiGoster.Click += new System.EventHandler(this.kaydiGoster_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İsim,
            this.Soyisim,
            this.OkulNo,
            this.Telefon,
            this.Vize1,
            this.Vize2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.Sienna;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(177, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 557);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // İsim
            // 
            this.İsim.Text = "İsim";
            this.İsim.Width = 136;
            // 
            // Soyisim
            // 
            this.Soyisim.Text = "Soyisim";
            this.Soyisim.Width = 142;
            // 
            // OkulNo
            // 
            this.OkulNo.Text = "Okul No";
            this.OkulNo.Width = 164;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 142;
            // 
            // Vize1
            // 
            this.Vize1.Text = "Vize1";
            this.Vize1.Width = 54;
            // 
            // Vize2
            // 
            this.Vize2.Text = "Vize2";
            this.Vize2.Width = 61;
            // 
            // yeniKayit
            // 
            this.yeniKayit.BackColor = System.Drawing.Color.MistyRose;
            this.yeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniKayit.Location = new System.Drawing.Point(31, 152);
            this.yeniKayit.Name = "yeniKayit";
            this.yeniKayit.Size = new System.Drawing.Size(140, 80);
            this.yeniKayit.TabIndex = 2;
            this.yeniKayit.Text = "Yeni Kayıt Ekle";
            this.yeniKayit.UseVisualStyleBackColor = false;
            this.yeniKayit.Click += new System.EventHandler(this.yeniKayit_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.IndianRed;
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(31, 276);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(140, 80);
            this.silButton.TabIndex = 3;
            this.silButton.Text = "Kayıt Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.guncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.Location = new System.Drawing.Point(31, 393);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(140, 80);
            this.guncelleButton.TabIndex = 4;
            this.guncelleButton.Text = "Kayıt Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = false;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1191, 605);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.yeniKayit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.kaydiGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kaydiGoster;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader İsim;
        private System.Windows.Forms.ColumnHeader Soyisim;
        private System.Windows.Forms.ColumnHeader OkulNo;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Vize1;
        private System.Windows.Forms.ColumnHeader Vize2;
        private System.Windows.Forms.Button yeniKayit;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button guncelleButton;
    }
}

