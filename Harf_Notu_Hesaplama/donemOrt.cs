using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Harf_Notu_Hesaplama
{
    public partial class donemOrt : Form
    {
        string[,] dersler = new string[10,3];
        static int dersnumarasi = 0;
        
        public donemOrt()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butonDersEkle_Click(object sender, EventArgs e)
        {
            if (dersnumarasi<10)
            {
                dersler[dersnumarasi, 0] = Convert.ToString(numericUpDownDersKredisi.Value);
                dersler[dersnumarasi, 1] = Convert.ToString(comboBoxDersAdi.Text);
                dersler[dersnumarasi, 2] = Convert.ToString(comboBoxHarfNotu.Text);
                comboBoxDersAdi.Items.Add(comboBoxDersAdi.Text);


                
                ListViewItem item3 = new ListViewItem(dersler[dersnumarasi, 0]);
                item3.SubItems.Add(dersler[dersnumarasi, 1]);
                item3.SubItems.Add(dersler[dersnumarasi, 2]);
                
                listView1.Items.Add(item3);
                dersnumarasi++;
                comboBoxDersAdi.Text = "Ders " + (dersnumarasi + 1);
            }
            else
            {
                MessageBox.Show("En fazla 10 ders ekleyebilirsin");
            }
        }

        private void donemOrt_Load(object sender, EventArgs e)
        {
            comboBoxDersAdi.Text = "Ders " + (dersnumarasi+1);
        }
        private void buttonDersDüzenle_Click(object sender, EventArgs e)
        {
            listView1.Items[row1].SubItems[0].Text = numericUpDownDersKredisi.Value.ToString();
            listView1.Items[row1].SubItems[1].Text = comboBoxDersAdi.Text;
            listView1.Items[row1].SubItems[2].Text = comboBoxHarfNotu.Text;
            comboBoxDersAdi.Items[row1] = comboBoxDersAdi.Text;
            dersler[row1, 0] = listView1.Items[row1].SubItems[0].Text;
            dersler[row1, 1] = listView1.Items[row1].SubItems[1].Text;
            dersler[row1, 2] = listView1.Items[row1].SubItems[2].Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double derssayisi=0;
            double gecici=0;
            double harfOrt;
            double kreditoplami=0;
            for (int i = 0; i < dersler.Length/3; i++)
            {
                harfOrt = HarfNotunuOrtalamaCevir(dersler[i, 2]);
                gecici = gecici + (Convert.ToDouble(dersler[i, 0])*harfOrt);
                if (Convert.ToDouble(dersler[i, 0]) * harfOrt!=0)
                {
                    derssayisi++;
                    kreditoplami = kreditoplami + Convert.ToDouble(dersler[i, 0]);
                }
                
            }
            labelOrt1.Text = Convert.ToString(gecici / kreditoplami);
            if (gecici / kreditoplami <= 4 && gecici / kreditoplami > 3)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\resimler\çok mutlu.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (gecici / kreditoplami <= 3 && gecici / kreditoplami > 2)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\resimler\mutlu.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (gecici / kreditoplami <= 2 && gecici / kreditoplami > 1)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\resimler\mutsuz.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (gecici / kreditoplami <= 1 && gecici / kreditoplami >= 0)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\resimler\çökmüş.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"..\..\resimler\çökmüş.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public double HarfNotunuOrtalamaCevir(string harfnotu)
        {
            switch (harfnotu)
            {
                case "AA":
                    return 4;
                case "BA":
                    return 3.5;
                case "BB":
                    return 3;
                case "CB":
                    return 2.5;
                case "CC":
                    return 2;
                case "DC":
                    return 1.5;
                case "DD":
                    return 1;
                case "FD":
                    return 0.5;
                case "FF":
                    return 0.000000001;
                default:
                    return 0;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int row1 = 0;
        private void comboBoxDersAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBoxDersAdi.Text;
            int x=0;
            for (int row = 0; row < dersler.GetLength(0); row++)
            {                
                if (dersler[row, 1] == secilen)
                {
                        x = row;                        
                }              
            }
            numericUpDownDersKredisi.Value = Convert.ToDecimal(dersler[x, 0]);
            comboBoxHarfNotu.Text = Convert.ToString(dersler[x, 2]);
            row1 = x;
        }

        private void donemOrt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
