namespace Harf_Notu_Hesaplama
{
    partial class donemOrt
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
            this.comboBoxHarfNotu = new System.Windows.Forms.ComboBox();
            this.numericUpDownDersKredisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butonDersEkle = new System.Windows.Forms.Button();
            this.comboBoxDersAdi = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderKredi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDersAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHarfNotu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDersDüzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOrt = new System.Windows.Forms.Label();
            this.labelOrt1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDersKredisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHarfNotu
            // 
            this.comboBoxHarfNotu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxHarfNotu.FormattingEnabled = true;
            this.comboBoxHarfNotu.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.comboBoxHarfNotu.Location = new System.Drawing.Point(425, 63);
            this.comboBoxHarfNotu.Name = "comboBoxHarfNotu";
            this.comboBoxHarfNotu.Size = new System.Drawing.Size(69, 24);
            this.comboBoxHarfNotu.TabIndex = 0;
            this.comboBoxHarfNotu.Text = "AA";
            // 
            // numericUpDownDersKredisi
            // 
            this.numericUpDownDersKredisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDownDersKredisi.Location = new System.Drawing.Point(44, 66);
            this.numericUpDownDersKredisi.Name = "numericUpDownDersKredisi";
            this.numericUpDownDersKredisi.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownDersKredisi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ders Kredisi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ders Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ders Harf Notu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // butonDersEkle
            // 
            this.butonDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butonDersEkle.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonDersEkle.Location = new System.Drawing.Point(528, 57);
            this.butonDersEkle.Name = "butonDersEkle";
            this.butonDersEkle.Size = new System.Drawing.Size(117, 38);
            this.butonDersEkle.TabIndex = 7;
            this.butonDersEkle.Text = "Ders Ekle";
            this.butonDersEkle.UseVisualStyleBackColor = false;
            this.butonDersEkle.Click += new System.EventHandler(this.butonDersEkle_Click);
            // 
            // comboBoxDersAdi
            // 
            this.comboBoxDersAdi.FormattingEnabled = true;
            this.comboBoxDersAdi.Location = new System.Drawing.Point(152, 66);
            this.comboBoxDersAdi.Name = "comboBoxDersAdi";
            this.comboBoxDersAdi.Size = new System.Drawing.Size(239, 24);
            this.comboBoxDersAdi.TabIndex = 8;
            this.comboBoxDersAdi.SelectedIndexChanged += new System.EventHandler(this.comboBoxDersAdi_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKredi,
            this.columnHeaderDersAdi,
            this.columnHeaderHarfNotu});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 262);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderKredi
            // 
            this.columnHeaderKredi.Text = "Kredi";
            this.columnHeaderKredi.Width = 90;
            // 
            // columnHeaderDersAdi
            // 
            this.columnHeaderDersAdi.Text = "Ders Adı";
            this.columnHeaderDersAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDersAdi.Width = 271;
            // 
            // columnHeaderHarfNotu
            // 
            this.columnHeaderHarfNotu.Text = "Harf Notu";
            this.columnHeaderHarfNotu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderHarfNotu.Width = 86;
            // 
            // buttonDersDüzenle
            // 
            this.buttonDersDüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDersDüzenle.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDersDüzenle.Location = new System.Drawing.Point(651, 58);
            this.buttonDersDüzenle.Name = "buttonDersDüzenle";
            this.buttonDersDüzenle.Size = new System.Drawing.Size(118, 38);
            this.buttonDersDüzenle.TabIndex = 10;
            this.buttonDersDüzenle.Text = "Ders Düzenle";
            this.buttonDersDüzenle.UseVisualStyleBackColor = false;
            this.buttonDersDüzenle.Click += new System.EventHandler(this.buttonDersDüzenle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ortalama Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOrt
            // 
            this.labelOrt.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrt.Location = new System.Drawing.Point(586, 177);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(133, 45);
            this.labelOrt.TabIndex = 12;
            this.labelOrt.Text = "Ortalama";
            this.labelOrt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrt1
            // 
            this.labelOrt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelOrt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrt1.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrt1.Location = new System.Drawing.Point(586, 222);
            this.labelOrt1.Name = "labelOrt1";
            this.labelOrt1.Size = new System.Drawing.Size(133, 49);
            this.labelOrt1.TabIndex = 13;
            this.labelOrt1.Text = "0,0";
            this.labelOrt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrt1.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(648, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "*Ders Düzenlemesi Yapmak İçin Ders Adı Listesinden Bir Değer Seçip Ders Düzenle B" +
    "utonuna Basabilirsiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(558, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 143);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // donemOrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelOrt1);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDersDüzenle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxDersAdi);
            this.Controls.Add(this.butonDersEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDersKredisi);
            this.Controls.Add(this.comboBoxHarfNotu);
            this.Name = "donemOrt";
            this.Text = "donemOrt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.donemOrt_FormClosing);
            this.Load += new System.EventHandler(this.donemOrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDersKredisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHarfNotu;
        private System.Windows.Forms.NumericUpDown numericUpDownDersKredisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butonDersEkle;
        private System.Windows.Forms.ComboBox comboBoxDersAdi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderKredi;
        private System.Windows.Forms.ColumnHeader columnHeaderDersAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderHarfNotu;
        private System.Windows.Forms.Button buttonDersDüzenle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.Label labelOrt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}