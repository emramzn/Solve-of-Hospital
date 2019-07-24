namespace Donem_odevi
{
    partial class Kullanıcı_Ekle
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
            this.adı_txt = new System.Windows.Forms.TextBox();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.soyadı_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kuladı_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kuladi_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.yetki_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // adı_txt
            // 
            this.adı_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adı_txt.Location = new System.Drawing.Point(145, 83);
            this.adı_txt.Name = "adı_txt";
            this.adı_txt.Size = new System.Drawing.Size(142, 31);
            this.adı_txt.TabIndex = 1;
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(210, 291);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(75, 43);
            this.kaydet_btn.TabIndex = 2;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // soyadı_txt
            // 
            this.soyadı_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadı_txt.Location = new System.Drawing.Point(143, 120);
            this.soyadı_txt.Name = "soyadı_txt";
            this.soyadı_txt.Size = new System.Drawing.Size(142, 31);
            this.soyadı_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı:";
            // 
            // kuladı_txt
            // 
            this.kuladı_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kuladı_txt.Location = new System.Drawing.Point(191, 163);
            this.kuladı_txt.Name = "kuladı_txt";
            this.kuladı_txt.Size = new System.Drawing.Size(142, 31);
            this.kuladı_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // sifre_txt
            // 
            this.sifre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_txt.Location = new System.Drawing.Point(145, 201);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(142, 31);
            this.sifre_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yetki:";
            // 
            // kuladi_btn
            // 
            this.kuladi_btn.Location = new System.Drawing.Point(129, 291);
            this.kuladi_btn.Name = "kuladi_btn";
            this.kuladi_btn.Size = new System.Drawing.Size(75, 43);
            this.kuladi_btn.TabIndex = 11;
            this.kuladi_btn.Text = "Kullanıcı Adı Oluştur";
            this.kuladi_btn.UseVisualStyleBackColor = true;
            this.kuladi_btn.Click += new System.EventHandler(this.kuladi_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(97, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Ekle";
            // 
            // yetki_combobox
            // 
            this.yetki_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yetki_combobox.FormattingEnabled = true;
            this.yetki_combobox.Items.AddRange(new object[] {
            "DKR",
            "DNM",
            "BSK"});
            this.yetki_combobox.Location = new System.Drawing.Point(145, 239);
            this.yetki_combobox.Name = "yetki_combobox";
            this.yetki_combobox.Size = new System.Drawing.Size(142, 33);
            this.yetki_combobox.TabIndex = 13;
            // 
            // Kullanıcı_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(472, 370);
            this.Controls.Add(this.yetki_combobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kuladi_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kuladı_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadı_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.adı_txt);
            this.Controls.Add(this.label1);
            this.Name = "Kullanıcı_Ekle";
            this.Text = "Kullanıcı Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adı_txt;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.TextBox soyadı_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kuladı_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kuladi_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox yetki_combobox;
    }
}