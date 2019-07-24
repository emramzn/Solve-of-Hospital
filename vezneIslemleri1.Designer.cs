namespace Donem_odevi
{
    partial class vezneIslemleri1
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
            this.BolumSecCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UcretAlBtn = new System.Windows.Forms.Button();
            this.VazgecBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcBox = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.islemBox = new System.Windows.Forms.TextBox();
            this.ucretBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastanın Kayıtlı olduğu Bölüm :";
            // 
            // BolumSecCombo
            // 
            this.BolumSecCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BolumSecCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BolumSecCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BolumSecCombo.FormattingEnabled = true;
            this.BolumSecCombo.Location = new System.Drawing.Point(358, 42);
            this.BolumSecCombo.Name = "BolumSecCombo";
            this.BolumSecCombo.Size = new System.Drawing.Size(240, 24);
            this.BolumSecCombo.TabIndex = 1;
            this.BolumSecCombo.SelectedValueChanged += new System.EventHandler(this.BolumSecCombo_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 295);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // UcretAlBtn
            // 
            this.UcretAlBtn.Location = new System.Drawing.Point(844, 293);
            this.UcretAlBtn.Name = "UcretAlBtn";
            this.UcretAlBtn.Size = new System.Drawing.Size(105, 39);
            this.UcretAlBtn.TabIndex = 3;
            this.UcretAlBtn.Text = "Ücret Al";
            this.UcretAlBtn.UseVisualStyleBackColor = true;
            this.UcretAlBtn.Click += new System.EventHandler(this.UcretAlBtn_Click);
            // 
            // VazgecBtn
            // 
            this.VazgecBtn.Location = new System.Drawing.Point(981, 293);
            this.VazgecBtn.Name = "VazgecBtn";
            this.VazgecBtn.Size = new System.Drawing.Size(92, 39);
            this.VazgecBtn.TabIndex = 4;
            this.VazgecBtn.Text = "Vazgeç";
            this.VazgecBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(833, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta T.C       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(833, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Adı        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(833, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gördüğü İşlem :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(833, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "İşlem Ücteti     :";
            // 
            // tcBox
            // 
            this.tcBox.Enabled = false;
            this.tcBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcBox.Location = new System.Drawing.Point(948, 100);
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(147, 23);
            this.tcBox.TabIndex = 8;
            // 
            // adBox
            // 
            this.adBox.Enabled = false;
            this.adBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adBox.Location = new System.Drawing.Point(948, 144);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(147, 23);
            this.adBox.TabIndex = 8;
            // 
            // islemBox
            // 
            this.islemBox.Enabled = false;
            this.islemBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemBox.Location = new System.Drawing.Point(948, 183);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(147, 23);
            this.islemBox.TabIndex = 9;
            // 
            // ucretBox
            // 
            this.ucretBox.Enabled = false;
            this.ucretBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucretBox.Location = new System.Drawing.Point(948, 227);
            this.ucretBox.Name = "ucretBox";
            this.ucretBox.Size = new System.Drawing.Size(147, 23);
            this.ucretBox.TabIndex = 10;
            // 
            // vezneIslemleri1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.ucretBox);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.tcBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VazgecBtn);
            this.Controls.Add(this.UcretAlBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BolumSecCombo);
            this.Controls.Add(this.label1);
            this.Name = "vezneIslemleri1";
            this.Text = "VEZNE İŞLEMLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vezneIslemleri1_FormClosed);
            this.Load += new System.EventHandler(this.vezneIslemleri1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BolumSecCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UcretAlBtn;
        private System.Windows.Forms.Button VazgecBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcBox;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.TextBox islemBox;
        private System.Windows.Forms.TextBox ucretBox;
    }
}