
namespace AracKiralama
{
    partial class MusteriTablosu
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
            this.MusteriID = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Sİl = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.EhliyetNo = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.TC = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.AdiSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MusteriID);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Btn_Sİl);
            this.groupBox1.Controls.Add(this.Btn_Guncelle);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Btn_Ekle);
            this.groupBox1.Controls.Add(this.EhliyetNo);
            this.groupBox1.Controls.Add(this.Telefon);
            this.groupBox1.Controls.Add(this.TC);
            this.groupBox1.Controls.Add(this.Adres);
            this.groupBox1.Controls.Add(this.AdiSoyadi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Müşteri ID";
            // 
            // MusteriID
            // 
            this.MusteriID.Location = new System.Drawing.Point(118, 48);
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.Size = new System.Drawing.Size(152, 20);
            this.MusteriID.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(118, 228);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(152, 20);
            this.Email.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-Mail";
            // 
            // Btn_Sİl
            // 
            this.Btn_Sİl.Location = new System.Drawing.Point(384, 256);
            this.Btn_Sİl.Name = "Btn_Sİl";
            this.Btn_Sİl.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sİl.TabIndex = 13;
            this.Btn_Sİl.Text = "Sil";
            this.Btn_Sİl.UseVisualStyleBackColor = true;
            this.Btn_Sİl.Click += new System.EventHandler(this.Btn_Sİl_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(492, 256);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 296);
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
            this.Btn_Ekle.Location = new System.Drawing.Point(274, 256);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekle.TabIndex = 10;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // EhliyetNo
            // 
            this.EhliyetNo.Location = new System.Drawing.Point(118, 189);
            this.EhliyetNo.Name = "EhliyetNo";
            this.EhliyetNo.Size = new System.Drawing.Size(152, 20);
            this.EhliyetNo.TabIndex = 9;
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(118, 121);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(152, 20);
            this.Telefon.TabIndex = 8;
            // 
            // TC
            // 
            this.TC.Location = new System.Drawing.Point(118, 153);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(152, 20);
            this.TC.TabIndex = 7;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(364, 48);
            this.Adres.Multiline = true;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(203, 116);
            this.Adres.TabIndex = 6;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.Location = new System.Drawing.Point(118, 86);
            this.AdiSoyadi.Name = "AdiSoyadi";
            this.AdiSoyadi.Size = new System.Drawing.Size(152, 20);
            this.AdiSoyadi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ehliyet No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Ve Soyad";
            // 
            // MusteriTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 486);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusteriTablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriTablosu";
            this.Load += new System.EventHandler(this.MusteriTablosu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.TextBox EhliyetNo;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.TextBox TC;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox AdiSoyadi;
        private System.Windows.Forms.Button Btn_Sİl;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MusteriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}