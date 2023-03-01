
namespace OBS
{
    partial class Guncel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ogrenciDataSet = new OBS.OgrenciDataSet();
            this.bilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgilerTableAdapter = new OBS.OgrenciDataSetTableAdapters.BilgilerTableAdapter();
            this.newnameLabel = new System.Windows.Forms.Label();
            this.newtelLabel = new System.Windows.Forms.Label();
            this.newsurnamekabel = new System.Windows.Forms.Label();
            this.newvize1Label = new System.Windows.Forms.Label();
            this.newvize2Label = new System.Windows.Forms.Label();
            this.isimtextBox = new System.Windows.Forms.TextBox();
            this.soyisimtextBox = new System.Windows.Forms.TextBox();
            this.telnotextBox = new System.Windows.Forms.TextBox();
            this.vize1textBox = new System.Windows.Forms.TextBox();
            this.vize2textBox = new System.Windows.Forms.TextBox();
            this.TamamlaButton = new System.Windows.Forms.Button();
            this.isimButton = new System.Windows.Forms.Button();
            this.soyisimButton = new System.Windows.Forms.Button();
            this.telnoButton = new System.Windows.Forms.Button();
            this.vize1Button = new System.Windows.Forms.Button();
            this.vize2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bigileri güncellenecek öğrenicin okul numarasını giriniz";
            // 
            // NotextBox
            // 
            this.NotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotextBox.Location = new System.Drawing.Point(164, 101);
            this.NotextBox.Multiline = true;
            this.NotextBox.Name = "NotextBox";
            this.NotextBox.Size = new System.Drawing.Size(199, 40);
            this.NotextBox.TabIndex = 1;
            this.NotextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hangi veriyi  güncellemek istiyorsunuz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İsim",
            "Soyisim",
            "Telefon",
            "Vize1",
            "Vize2"});
            this.comboBox1.Location = new System.Drawing.Point(386, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ogrenciDataSet
            // 
            this.ogrenciDataSet.DataSetName = "OgrenciDataSet";
            this.ogrenciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgilerBindingSource
            // 
            this.bilgilerBindingSource.DataMember = "Bilgiler";
            this.bilgilerBindingSource.DataSource = this.ogrenciDataSet;
            // 
            // bilgilerTableAdapter
            // 
            this.bilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // newnameLabel
            // 
            this.newnameLabel.AutoSize = true;
            this.newnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newnameLabel.Location = new System.Drawing.Point(12, 218);
            this.newnameLabel.Name = "newnameLabel";
            this.newnameLabel.Size = new System.Drawing.Size(91, 25);
            this.newnameLabel.TabIndex = 4;
            this.newnameLabel.Text = "Yeni İsim";
            this.newnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newnameLabel.Visible = false;
            // 
            // newtelLabel
            // 
            this.newtelLabel.AutoSize = true;
            this.newtelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newtelLabel.Location = new System.Drawing.Point(14, 315);
            this.newtelLabel.Name = "newtelLabel";
            this.newtelLabel.Size = new System.Drawing.Size(122, 25);
            this.newtelLabel.TabIndex = 5;
            this.newtelLabel.Text = "Yeni Telefon";
            this.newtelLabel.Visible = false;
            // 
            // newsurnamekabel
            // 
            this.newsurnamekabel.AutoSize = true;
            this.newsurnamekabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newsurnamekabel.Location = new System.Drawing.Point(14, 270);
            this.newsurnamekabel.Name = "newsurnamekabel";
            this.newsurnamekabel.Size = new System.Drawing.Size(125, 25);
            this.newsurnamekabel.TabIndex = 6;
            this.newsurnamekabel.Text = "Yeni Soyisim";
            this.newsurnamekabel.Visible = false;
            // 
            // newvize1Label
            // 
            this.newvize1Label.AutoSize = true;
            this.newvize1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newvize1Label.Location = new System.Drawing.Point(14, 362);
            this.newvize1Label.Name = "newvize1Label";
            this.newvize1Label.Size = new System.Drawing.Size(111, 25);
            this.newvize1Label.TabIndex = 7;
            this.newvize1Label.Text = "Yeni Vize1 ";
            this.newvize1Label.Visible = false;
            // 
            // newvize2Label
            // 
            this.newvize2Label.AutoSize = true;
            this.newvize2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newvize2Label.Location = new System.Drawing.Point(14, 411);
            this.newvize2Label.Name = "newvize2Label";
            this.newvize2Label.Size = new System.Drawing.Size(106, 25);
            this.newvize2Label.TabIndex = 8;
            this.newvize2Label.Text = "Yeni Vize2";
            this.newvize2Label.Visible = false;
            this.newvize2Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // isimtextBox
            // 
            this.isimtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimtextBox.Location = new System.Drawing.Point(145, 218);
            this.isimtextBox.Multiline = true;
            this.isimtextBox.Name = "isimtextBox";
            this.isimtextBox.Size = new System.Drawing.Size(133, 34);
            this.isimtextBox.TabIndex = 9;
            this.isimtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isimtextBox.Visible = false;
            // 
            // soyisimtextBox
            // 
            this.soyisimtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimtextBox.Location = new System.Drawing.Point(145, 270);
            this.soyisimtextBox.Multiline = true;
            this.soyisimtextBox.Name = "soyisimtextBox";
            this.soyisimtextBox.Size = new System.Drawing.Size(133, 34);
            this.soyisimtextBox.TabIndex = 10;
            this.soyisimtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soyisimtextBox.Visible = false;
            // 
            // telnotextBox
            // 
            this.telnotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telnotextBox.Location = new System.Drawing.Point(145, 315);
            this.telnotextBox.Multiline = true;
            this.telnotextBox.Name = "telnotextBox";
            this.telnotextBox.Size = new System.Drawing.Size(133, 34);
            this.telnotextBox.TabIndex = 11;
            this.telnotextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telnotextBox.Visible = false;
            // 
            // vize1textBox
            // 
            this.vize1textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vize1textBox.Location = new System.Drawing.Point(145, 362);
            this.vize1textBox.Multiline = true;
            this.vize1textBox.Name = "vize1textBox";
            this.vize1textBox.Size = new System.Drawing.Size(133, 34);
            this.vize1textBox.TabIndex = 12;
            this.vize1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vize1textBox.Visible = false;
            // 
            // vize2textBox
            // 
            this.vize2textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vize2textBox.Location = new System.Drawing.Point(145, 402);
            this.vize2textBox.Multiline = true;
            this.vize2textBox.Name = "vize2textBox";
            this.vize2textBox.Size = new System.Drawing.Size(133, 34);
            this.vize2textBox.TabIndex = 13;
            this.vize2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vize2textBox.Visible = false;
            // 
            // TamamlaButton
            // 
            this.TamamlaButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TamamlaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TamamlaButton.Location = new System.Drawing.Point(280, 464);
            this.TamamlaButton.Name = "TamamlaButton";
            this.TamamlaButton.Size = new System.Drawing.Size(121, 48);
            this.TamamlaButton.TabIndex = 14;
            this.TamamlaButton.Text = "Tamamla";
            this.TamamlaButton.UseVisualStyleBackColor = false;
            this.TamamlaButton.Click += new System.EventHandler(this.OnaylaButton_Click);
            // 
            // isimButton
            // 
            this.isimButton.BackColor = System.Drawing.Color.Aquamarine;
            this.isimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimButton.Location = new System.Drawing.Point(420, 213);
            this.isimButton.Name = "isimButton";
            this.isimButton.Size = new System.Drawing.Size(98, 39);
            this.isimButton.TabIndex = 16;
            this.isimButton.Text = "Onayla";
            this.isimButton.UseVisualStyleBackColor = false;
            this.isimButton.Visible = false;
            this.isimButton.Click += new System.EventHandler(this.isimButton_Click);
            // 
            // soyisimButton
            // 
            this.soyisimButton.BackColor = System.Drawing.Color.Aquamarine;
            this.soyisimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimButton.Location = new System.Drawing.Point(420, 266);
            this.soyisimButton.Name = "soyisimButton";
            this.soyisimButton.Size = new System.Drawing.Size(98, 39);
            this.soyisimButton.TabIndex = 17;
            this.soyisimButton.Text = "Onayla";
            this.soyisimButton.UseVisualStyleBackColor = false;
            this.soyisimButton.Visible = false;
            this.soyisimButton.Click += new System.EventHandler(this.soyisimButton_Click);
            // 
            // telnoButton
            // 
            this.telnoButton.BackColor = System.Drawing.Color.Aquamarine;
            this.telnoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telnoButton.Location = new System.Drawing.Point(420, 314);
            this.telnoButton.Name = "telnoButton";
            this.telnoButton.Size = new System.Drawing.Size(98, 39);
            this.telnoButton.TabIndex = 18;
            this.telnoButton.Text = "Onayla";
            this.telnoButton.UseVisualStyleBackColor = false;
            this.telnoButton.Visible = false;
            this.telnoButton.Click += new System.EventHandler(this.telnoButton_Click);
            // 
            // vize1Button
            // 
            this.vize1Button.BackColor = System.Drawing.Color.Aquamarine;
            this.vize1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vize1Button.Location = new System.Drawing.Point(420, 357);
            this.vize1Button.Name = "vize1Button";
            this.vize1Button.Size = new System.Drawing.Size(98, 39);
            this.vize1Button.TabIndex = 19;
            this.vize1Button.Text = "Onayla";
            this.vize1Button.UseVisualStyleBackColor = false;
            this.vize1Button.Visible = false;
            this.vize1Button.Click += new System.EventHandler(this.vize1Button_Click);
            // 
            // vize2Button
            // 
            this.vize2Button.BackColor = System.Drawing.Color.Aquamarine;
            this.vize2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vize2Button.Location = new System.Drawing.Point(420, 401);
            this.vize2Button.Name = "vize2Button";
            this.vize2Button.Size = new System.Drawing.Size(98, 39);
            this.vize2Button.TabIndex = 20;
            this.vize2Button.Text = "Onayla";
            this.vize2Button.UseVisualStyleBackColor = false;
            this.vize2Button.Visible = false;
            this.vize2Button.Click += new System.EventHandler(this.vize2Button_Click);
            // 
            // Guncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(566, 524);
            this.Controls.Add(this.vize2Button);
            this.Controls.Add(this.vize1Button);
            this.Controls.Add(this.telnoButton);
            this.Controls.Add(this.soyisimButton);
            this.Controls.Add(this.isimButton);
            this.Controls.Add(this.TamamlaButton);
            this.Controls.Add(this.vize2textBox);
            this.Controls.Add(this.vize1textBox);
            this.Controls.Add(this.telnotextBox);
            this.Controls.Add(this.soyisimtextBox);
            this.Controls.Add(this.isimtextBox);
            this.Controls.Add(this.newvize2Label);
            this.Controls.Add(this.newvize1Label);
            this.Controls.Add(this.newsurnamekabel);
            this.Controls.Add(this.newtelLabel);
            this.Controls.Add(this.newnameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Guncel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guncel";
            this.Load += new System.EventHandler(this.Guncel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private OgrenciDataSet ogrenciDataSet;
        private System.Windows.Forms.BindingSource bilgilerBindingSource;
        private OgrenciDataSetTableAdapters.BilgilerTableAdapter bilgilerTableAdapter;
        private System.Windows.Forms.Label newnameLabel;
        private System.Windows.Forms.Label newtelLabel;
        private System.Windows.Forms.Label newsurnamekabel;
        private System.Windows.Forms.Label newvize1Label;
        private System.Windows.Forms.Label newvize2Label;
        private System.Windows.Forms.TextBox isimtextBox;
        private System.Windows.Forms.TextBox soyisimtextBox;
        private System.Windows.Forms.TextBox telnotextBox;
        private System.Windows.Forms.TextBox vize1textBox;
        private System.Windows.Forms.TextBox vize2textBox;
        private System.Windows.Forms.Button TamamlaButton;
        private System.Windows.Forms.Button isimButton;
        private System.Windows.Forms.Button soyisimButton;
        private System.Windows.Forms.Button telnoButton;
        private System.Windows.Forms.Button vize1Button;
        private System.Windows.Forms.Button vize2Button;
    }
}