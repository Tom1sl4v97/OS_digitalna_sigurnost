namespace OS2_kriptiranje
{
    partial class kriptiranje_form
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
            this.text_tbx = new System.Windows.Forms.TextBox();
            this.text_lb = new System.Windows.Forms.Label();
            this.stvori_kljuceve_btn = new System.Windows.Forms.Button();
            this.pohrani_text_btn = new System.Windows.Forms.Button();
            this.Kriptiraj_rsa_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dekriptiraj_rsa_btn = new System.Windows.Forms.Button();
            this.Dekriptiraj_aes_btn = new System.Windows.Forms.Button();
            this.Kriptiraj_aes_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.provjeri_digitalni_potpis_btn = new System.Windows.Forms.Button();
            this.sazetak_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.digitalni_potpis_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_tbx
            // 
            this.text_tbx.Location = new System.Drawing.Point(12, 48);
            this.text_tbx.Multiline = true;
            this.text_tbx.Name = "text_tbx";
            this.text_tbx.Size = new System.Drawing.Size(604, 111);
            this.text_tbx.TabIndex = 0;
            // 
            // text_lb
            // 
            this.text_lb.AutoSize = true;
            this.text_lb.Location = new System.Drawing.Point(12, 29);
            this.text_lb.Name = "text_lb";
            this.text_lb.Size = new System.Drawing.Size(98, 13);
            this.text_lb.TabIndex = 1;
            this.text_lb.Text = "Unesite željeni text:";
            // 
            // stvori_kljuceve_btn
            // 
            this.stvori_kljuceve_btn.Location = new System.Drawing.Point(12, 281);
            this.stvori_kljuceve_btn.Name = "stvori_kljuceve_btn";
            this.stvori_kljuceve_btn.Size = new System.Drawing.Size(114, 36);
            this.stvori_kljuceve_btn.TabIndex = 2;
            this.stvori_kljuceve_btn.Text = "Stvori ključeve";
            this.stvori_kljuceve_btn.UseVisualStyleBackColor = true;
            this.stvori_kljuceve_btn.Click += new System.EventHandler(this.stvori_kljuceve_btn_Click);
            // 
            // pohrani_text_btn
            // 
            this.pohrani_text_btn.Location = new System.Drawing.Point(12, 174);
            this.pohrani_text_btn.Name = "pohrani_text_btn";
            this.pohrani_text_btn.Size = new System.Drawing.Size(114, 36);
            this.pohrani_text_btn.TabIndex = 3;
            this.pohrani_text_btn.Text = "Pohrani text";
            this.pohrani_text_btn.UseVisualStyleBackColor = true;
            this.pohrani_text_btn.Click += new System.EventHandler(this.pohrani_text_btn_Click);
            // 
            // Kriptiraj_rsa_btn
            // 
            this.Kriptiraj_rsa_btn.Location = new System.Drawing.Point(6, 19);
            this.Kriptiraj_rsa_btn.Name = "Kriptiraj_rsa_btn";
            this.Kriptiraj_rsa_btn.Size = new System.Drawing.Size(114, 36);
            this.Kriptiraj_rsa_btn.TabIndex = 4;
            this.Kriptiraj_rsa_btn.Text = "Kriptiraj text";
            this.Kriptiraj_rsa_btn.UseVisualStyleBackColor = true;
            this.Kriptiraj_rsa_btn.Click += new System.EventHandler(this.Kriptiraj_rsa_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dekriptiraj_rsa_btn);
            this.groupBox1.Controls.Add(this.Kriptiraj_rsa_btn);
            this.groupBox1.Location = new System.Drawing.Point(145, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA kriptiranje";
            // 
            // Dekriptiraj_rsa_btn
            // 
            this.Dekriptiraj_rsa_btn.Location = new System.Drawing.Point(6, 61);
            this.Dekriptiraj_rsa_btn.Name = "Dekriptiraj_rsa_btn";
            this.Dekriptiraj_rsa_btn.Size = new System.Drawing.Size(114, 36);
            this.Dekriptiraj_rsa_btn.TabIndex = 5;
            this.Dekriptiraj_rsa_btn.Text = "Dekriptiraj text";
            this.Dekriptiraj_rsa_btn.UseVisualStyleBackColor = true;
            this.Dekriptiraj_rsa_btn.Click += new System.EventHandler(this.Dekriptiraj_rsa_btn_Click);
            // 
            // Dekriptiraj_aes_btn
            // 
            this.Dekriptiraj_aes_btn.Location = new System.Drawing.Point(6, 61);
            this.Dekriptiraj_aes_btn.Name = "Dekriptiraj_aes_btn";
            this.Dekriptiraj_aes_btn.Size = new System.Drawing.Size(114, 36);
            this.Dekriptiraj_aes_btn.TabIndex = 5;
            this.Dekriptiraj_aes_btn.Text = "Dekriptiraj text";
            this.Dekriptiraj_aes_btn.UseVisualStyleBackColor = true;
            this.Dekriptiraj_aes_btn.Click += new System.EventHandler(this.Dekriptiraj_aes_btn_Click);
            // 
            // Kriptiraj_aes_btn
            // 
            this.Kriptiraj_aes_btn.Location = new System.Drawing.Point(6, 19);
            this.Kriptiraj_aes_btn.Name = "Kriptiraj_aes_btn";
            this.Kriptiraj_aes_btn.Size = new System.Drawing.Size(114, 36);
            this.Kriptiraj_aes_btn.TabIndex = 4;
            this.Kriptiraj_aes_btn.Text = "Kriptiraj text";
            this.Kriptiraj_aes_btn.UseVisualStyleBackColor = true;
            this.Kriptiraj_aes_btn.Click += new System.EventHandler(this.Kriptiraj_aes_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dekriptiraj_aes_btn);
            this.groupBox2.Controls.Add(this.Kriptiraj_aes_btn);
            this.groupBox2.Location = new System.Drawing.Point(304, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES kriptiranje";
            // 
            // provjeri_digitalni_potpis_btn
            // 
            this.provjeri_digitalni_potpis_btn.Location = new System.Drawing.Point(6, 103);
            this.provjeri_digitalni_potpis_btn.Name = "provjeri_digitalni_potpis_btn";
            this.provjeri_digitalni_potpis_btn.Size = new System.Drawing.Size(114, 36);
            this.provjeri_digitalni_potpis_btn.TabIndex = 5;
            this.provjeri_digitalni_potpis_btn.Text = "Provjeri digitalni potpis";
            this.provjeri_digitalni_potpis_btn.UseVisualStyleBackColor = true;
            this.provjeri_digitalni_potpis_btn.Click += new System.EventHandler(this.provjeri_digitalni_potpis_btn_Click);
            // 
            // sazetak_btn
            // 
            this.sazetak_btn.Location = new System.Drawing.Point(6, 19);
            this.sazetak_btn.Name = "sazetak_btn";
            this.sazetak_btn.Size = new System.Drawing.Size(114, 36);
            this.sazetak_btn.TabIndex = 4;
            this.sazetak_btn.Text = "Kreiraj sažetak";
            this.sazetak_btn.UseVisualStyleBackColor = true;
            this.sazetak_btn.Click += new System.EventHandler(this.sazetak_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.digitalni_potpis_btn);
            this.groupBox3.Controls.Add(this.provjeri_digitalni_potpis_btn);
            this.groupBox3.Controls.Add(this.sazetak_btn);
            this.groupBox3.Location = new System.Drawing.Point(463, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 157);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Digitalno potpisivanje";
            // 
            // digitalni_potpis_btn
            // 
            this.digitalni_potpis_btn.Location = new System.Drawing.Point(6, 61);
            this.digitalni_potpis_btn.Name = "digitalni_potpis_btn";
            this.digitalni_potpis_btn.Size = new System.Drawing.Size(114, 36);
            this.digitalni_potpis_btn.TabIndex = 6;
            this.digitalni_potpis_btn.Text = "Kreiraj digitalni potpis";
            this.digitalni_potpis_btn.UseVisualStyleBackColor = true;
            this.digitalni_potpis_btn.Click += new System.EventHandler(this.digitalni_potpis_btn_Click);
            // 
            // kriptiranje_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pohrani_text_btn);
            this.Controls.Add(this.stvori_kljuceve_btn);
            this.Controls.Add(this.text_lb);
            this.Controls.Add(this.text_tbx);
            this.Name = "kriptiranje_form";
            this.Text = "kriptiranje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_tbx;
        private System.Windows.Forms.Label text_lb;
        private System.Windows.Forms.Button stvori_kljuceve_btn;
        private System.Windows.Forms.Button pohrani_text_btn;
        private System.Windows.Forms.Button Kriptiraj_rsa_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dekriptiraj_rsa_btn;
        private System.Windows.Forms.Button Dekriptiraj_aes_btn;
        private System.Windows.Forms.Button Kriptiraj_aes_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button provjeri_digitalni_potpis_btn;
        private System.Windows.Forms.Button sazetak_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button digitalni_potpis_btn;
    }
}

