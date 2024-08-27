
namespace AracKiralama
{
    partial class SozlesmeForm
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
            this.date_C_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.date_G_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.KiraUcret = new System.Windows.Forms.TextBox();
            this.T_KiraSekli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_SozlesmeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.T_SozlesmeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.date_C_Tarihi);
            this.groupBox1.Controls.Add(this.date_G_Tarihi);
            this.groupBox1.Controls.Add(this.Btn_Guncelle);
            this.groupBox1.Controls.Add(this.Btn_Ekle);
            this.groupBox1.Controls.Add(this.KiraUcret);
            this.groupBox1.Controls.Add(this.T_KiraSekli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sözleşme Bilgileri";
            // 
            // date_C_Tarihi
            // 
            this.date_C_Tarihi.Location = new System.Drawing.Point(111, 198);
            this.date_C_Tarihi.Name = "date_C_Tarihi";
            this.date_C_Tarihi.Size = new System.Drawing.Size(200, 20);
            this.date_C_Tarihi.TabIndex = 15;
            // 
            // date_G_Tarihi
            // 
            this.date_G_Tarihi.Location = new System.Drawing.Point(111, 162);
            this.date_G_Tarihi.Name = "date_G_Tarihi";
            this.date_G_Tarihi.Size = new System.Drawing.Size(200, 20);
            this.date_G_Tarihi.TabIndex = 14;
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(359, 139);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guncelle.TabIndex = 12;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(359, 85);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekle.TabIndex = 10;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // KiraUcret
            // 
            this.KiraUcret.Location = new System.Drawing.Point(111, 127);
            this.KiraUcret.Name = "KiraUcret";
            this.KiraUcret.Size = new System.Drawing.Size(200, 20);
            this.KiraUcret.TabIndex = 8;
            // 
            // T_KiraSekli
            // 
            this.T_KiraSekli.Location = new System.Drawing.Point(111, 92);
            this.T_KiraSekli.Name = "T_KiraSekli";
            this.T_KiraSekli.Size = new System.Drawing.Size(200, 20);
            this.T_KiraSekli.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kira Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giriş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kira Şekli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(6, 248);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(438, 211);
            this.dataGridView1.TabIndex = 17;
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
            // T_SozlesmeID
            // 
            this.T_SozlesmeID.Location = new System.Drawing.Point(111, 56);
            this.T_SozlesmeID.Name = "T_SozlesmeID";
            this.T_SozlesmeID.Size = new System.Drawing.Size(200, 20);
            this.T_SozlesmeID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sözleşme ID";
            // 
            // SozlesmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 501);
            this.Controls.Add(this.groupBox1);
            this.Name = "SozlesmeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SozlesmeForm";
            this.Load += new System.EventHandler(this.SozlesmeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.Sozlesme_Load);


        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_C_Tarihi;
        private System.Windows.Forms.DateTimePicker date_G_Tarihi;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.TextBox KiraUcret;
        private System.Windows.Forms.TextBox T_KiraSekli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox T_SozlesmeID;
        private System.Windows.Forms.Label label2;
    }
}