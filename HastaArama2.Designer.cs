namespace Donem_odevi
{
    partial class HastaArama2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaArama2));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcRadioBtn = new System.Windows.Forms.RadioButton();
            this.tcText = new System.Windows.Forms.TextBox();
            this.adRadioBtn = new System.Windows.Forms.RadioButton();
            this.adText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.tcRadioBtn);
            this.groupBox6.Controls.Add(this.tcText);
            this.groupBox6.Controls.Add(this.adRadioBtn);
            this.groupBox6.Controls.Add(this.adText);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(99, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(465, 128);
            this.groupBox6.TabIndex = 190;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Arama Kriterleri";
            // 
            // button2
            // 
            this.button2.Image = global::Donem_odevi.Properties.Resources.magnifyingglass_48;
            this.button2.Location = new System.Drawing.Point(340, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 34);
            this.button2.TabIndex = 193;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Donem_odevi.Properties.Resources.clear_24;
            this.button1.Location = new System.Drawing.Point(394, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 34);
            this.button1.TabIndex = 193;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcRadioBtn
            // 
            this.tcRadioBtn.AutoSize = true;
            this.tcRadioBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.tcRadioBtn.Location = new System.Drawing.Point(27, 80);
            this.tcRadioBtn.Name = "tcRadioBtn";
            this.tcRadioBtn.Size = new System.Drawing.Size(109, 22);
            this.tcRadioBtn.TabIndex = 4;
            this.tcRadioBtn.TabStop = true;
            this.tcRadioBtn.Text = "T.C Filtrele";
            this.tcRadioBtn.UseVisualStyleBackColor = true;
            this.tcRadioBtn.CheckedChanged += new System.EventHandler(this.tcRadioBtn_CheckedChanged);
            // 
            // tcText
            // 
            this.tcText.Enabled = false;
            this.tcText.Location = new System.Drawing.Point(163, 79);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(171, 26);
            this.tcText.TabIndex = 3;
            // 
            // adRadioBtn
            // 
            this.adRadioBtn.AutoSize = true;
            this.adRadioBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.adRadioBtn.Location = new System.Drawing.Point(27, 35);
            this.adRadioBtn.Name = "adRadioBtn";
            this.adRadioBtn.Size = new System.Drawing.Size(114, 22);
            this.adRadioBtn.TabIndex = 2;
            this.adRadioBtn.TabStop = true;
            this.adRadioBtn.Text = "Adı Filitrele";
            this.adRadioBtn.UseVisualStyleBackColor = true;
            this.adRadioBtn.CheckedChanged += new System.EventHandler(this.adRadioBtn_CheckedChanged);
            // 
            // adText
            // 
            this.adText.Enabled = false;
            this.adText.Location = new System.Drawing.Point(163, 34);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(171, 26);
            this.adText.TabIndex = 1;
            this.adText.TextChanged += new System.EventHandler(this.adText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(953, 245);
            this.dataGridView1.TabIndex = 191;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Donem_odevi.Properties.Resources.hospital_landing_sign_healthcare_medical_health_37533065522c35aa_512x5121;
            this.pictureBox2.Location = new System.Drawing.Point(941, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 193;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(971, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 192;
            this.pictureBox1.TabStop = false;
            // 
            // HastaArama2
            // 
            this.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 468);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaArama2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Arama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaArama2_FormClosed);
            this.Load += new System.EventHandler(this.HastaArama2_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton adRadioBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton tcRadioBtn;
        private System.Windows.Forms.TextBox tcText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}