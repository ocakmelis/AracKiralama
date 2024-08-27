
namespace AracKiralama
{
    partial class KullaniciEklemeForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.T_KullaniciID = new System.Windows.Forms.TextBox();
            this.Btn_Sİl = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.T_Soyadi = new System.Windows.Forms.TextBox();
            this.T_Sifre = new System.Windows.Forms.TextBox();
            this.T_Adi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.T_KullaniciID);
            this.groupBox1.Controls.Add(this.Btn_Sİl);
            this.groupBox1.Controls.Add(this.Btn_Guncelle);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Btn_Ekle);
            this.groupBox1.Controls.Add(this.T_Soyadi);
            this.groupBox1.Controls.Add(this.T_Sifre);
            this.groupBox1.Controls.Add(this.T_Adi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kullanıcı ID";
            // 
            // T_KullaniciID
            // 
            this.T_KullaniciID.Location = new System.Drawing.Point(118, 48);
            this.T_KullaniciID.Name = "T_KullaniciID";
            this.T_KullaniciID.Size = new System.Drawing.Size(152, 20);
            this.T_KullaniciID.TabIndex = 17;
            // 
            // Btn_Sİl
            // 
            this.Btn_Sİl.Location = new System.Drawing.Point(346, 84);
            this.Btn_Sİl.Name = "Btn_Sİl";
            this.Btn_Sİl.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sİl.TabIndex = 13;
            this.Btn_Sİl.Text = "Sil";
            this.Btn_Sİl.UseVisualStyleBackColor = true;
            this.Btn_Sİl.Click += new System.EventHandler(this.Btn_Sİl_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(346, 124);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guncelle.TabIndex = 12;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(6, 211);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MusteriID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(346, 45);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekle.TabIndex = 10;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // T_Soyadi
            // 
            this.T_Soyadi.Location = new System.Drawing.Point(118, 121);
            this.T_Soyadi.Name = "T_Soyadi";
            this.T_Soyadi.Size = new System.Drawing.Size(152, 20);
            this.T_Soyadi.TabIndex = 8;
            // 
            // T_Sifre
            // 
            this.T_Sifre.Location = new System.Drawing.Point(118, 153);
            this.T_Sifre.Name = "T_Sifre";
            this.T_Sifre.Size = new System.Drawing.Size(152, 20);
            this.T_Sifre.TabIndex = 7;
            // 
            // T_Adi
            // 
            this.T_Adi.Location = new System.Drawing.Point(118, 86);
            this.T_Adi.Name = "T_Adi";
            this.T_Adi.Size = new System.Drawing.Size(152, 20);
            this.T_Adi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // KullaniciEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 395);
            this.Controls.Add(this.groupBox1);
            this.Name = "KullaniciEklemeForm";
            this.Text = "KullaniciEklemeForm";
            this.Load += new System.EventHandler(this.KullaniciEklemeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox T_KullaniciID;
        private System.Windows.Forms.Button Btn_Sİl;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.TextBox T_Soyadi;
        private System.Windows.Forms.TextBox T_Sifre;
        private System.Windows.Forms.TextBox T_Adi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}