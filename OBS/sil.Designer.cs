
namespace OBS
{
    partial class sil
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
            this.label1 = new System.Windows.Forms.Label();
            this.silTextbox = new System.Windows.Forms.TextBox();
            this.onaylaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek öğrencinin okul numarasını giriniz";
            // 
            // silTextbox
            // 
            this.silTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silTextbox.Location = new System.Drawing.Point(138, 166);
            this.silTextbox.Multiline = true;
            this.silTextbox.Name = "silTextbox";
            this.silTextbox.Size = new System.Drawing.Size(256, 47);
            this.silTextbox.TabIndex = 1;
            // 
            // onaylaButton
            // 
            this.onaylaButton.BackColor = System.Drawing.Color.Coral;
            this.onaylaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaButton.Location = new System.Drawing.Point(46, 348);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(126, 50);
            this.onaylaButton.TabIndex = 2;
            this.onaylaButton.Text = "Onayla";
            this.onaylaButton.UseVisualStyleBackColor = false;
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(558, 462);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.silTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox silTextbox;
        private System.Windows.Forms.Button onaylaButton;
    }
}