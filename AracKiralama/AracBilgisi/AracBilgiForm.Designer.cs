
namespace AracKiralama
{
    partial class AracBilgiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Sec = new System.Windows.Forms.Button();
            this.resim = new System.Windows.Forms.PictureBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.km = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yil = new System.Windows.Forms.TextBox();
            this.yakit = new System.Windows.Forms.TextBox();
            this.durum = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.kira = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.plaka = new System.Windows.Forms.TextBox();
            this.seri = new System.Windows.Forms.TextBox();
            this.renk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AracID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AracID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Btn_Sec);
            this.groupBox1.Controls.Add(this.resim);
            this.groupBox1.Controls.Add(this.Tarih);
            this.groupBox1.Controls.Add(this.Btn_Sil);
            this.groupBox1.Controls.Add(this.Btn_Guncelle);
            this.groupBox1.Controls.Add(this.Btn_Ekle);
            this.groupBox1.Controls.Add(this.km);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.yil);
            this.groupBox1.Controls.Add(this.yakit);
            this.groupBox1.Controls.Add(this.durum);
            this.groupBox1.Controls.Add(this.marka);
            this.groupBox1.Controls.Add(this.kira);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.plaka);
            this.groupBox1.Controls.Add(this.seri);
            this.groupBox1.Controls.Add(this.renk);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // Btn_Sec
            // 
            this.Btn_Sec.Location = new System.Drawing.Point(651, 264);
            this.Btn_Sec.Name = "Btn_Sec";
            this.Btn_Sec.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sec.TabIndex = 32;
            this.Btn_Sec.Text = "Resim Seç";
            this.Btn_Sec.UseVisualStyleBackColor = true;
            this.Btn_Sec.Click += new System.EventHandler(this.Btn_Sec_Click);
            // 
            // resim
            // 
            this.resim.Location = new System.Drawing.Point(633, 42);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(174, 174);
            this.resim.TabIndex = 31;
            this.resim.TabStop = false;
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(334, 135);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(180, 20);
            this.Tarih.TabIndex = 30;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(188, 264);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sil.TabIndex = 29;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(295, 264);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guncelle.TabIndex = 28;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(57, 264);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekle.TabIndex = 27;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // km
            // 
            this.km.Location = new System.Drawing.Point(66, 196);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(180, 20);
            this.km.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Model";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(6, 314);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 171);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // yil
            // 
            this.yil.Location = new System.Drawing.Point(66, 164);
            this.yil.Name = "yil";
            this.yil.Size = new System.Drawing.Size(180, 20);
            this.yil.TabIndex = 23;
            // 
            // yakit
            // 
            this.yakit.Location = new System.Drawing.Point(334, 71);
            this.yakit.Name = "yakit";
            this.yakit.Size = new System.Drawing.Size(180, 20);
            this.yakit.TabIndex = 22;
            // 
            // durum
            // 
            this.durum.Location = new System.Drawing.Point(334, 167);
            this.durum.Multiline = true;
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(180, 64);
            this.durum.TabIndex = 21;
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(66, 36);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 20);
            this.marka.TabIndex = 20;
            // 
            // kira
            // 
            this.kira.Location = new System.Drawing.Point(334, 104);
            this.kira.Name = "kira";
            this.kira.Size = new System.Drawing.Size(180, 20);
            this.kira.TabIndex = 18;
            // 
            // model
            // 
            this.model.AcceptsReturn = true;
            this.model.Location = new System.Drawing.Point(66, 71);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(180, 20);
            this.model.TabIndex = 15;
            // 
            // plaka
            // 
            this.plaka.Location = new System.Drawing.Point(66, 104);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(180, 20);
            this.plaka.TabIndex = 14;
            // 
            // seri
            // 
            this.seri.Location = new System.Drawing.Point(66, 135);
            this.seri.Name = "seri";
            this.seri.Size = new System.Drawing.Size(180, 20);
            this.seri.TabIndex = 13;
            // 
            // renk
            // 
            this.renk.Location = new System.Drawing.Point(334, 39);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(180, 20);
            this.renk.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Km";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Yakıt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = " Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kira Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Araç ID";
            // 
            // AracID
            // 
            this.AracID.Location = new System.Drawing.Point(66, 226);
            this.AracID.Name = "AracID";
            this.AracID.Size = new System.Drawing.Size(180, 20);
            this.AracID.TabIndex = 34;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "AracID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // AracBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "AracBilgiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracBilgiForm";
            this.Load += new System.EventHandler(this.AracBilgiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox yil;
        private System.Windows.Forms.TextBox yakit;
        private System.Windows.Forms.TextBox durum;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox kira;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox plaka;
        private System.Windows.Forms.TextBox seri;
        private System.Windows.Forms.TextBox renk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox km;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Sec;
        private System.Windows.Forms.TextBox AracID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}