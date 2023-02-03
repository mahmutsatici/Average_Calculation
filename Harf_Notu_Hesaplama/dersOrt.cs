using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harf_Notu_Hesaplama
{
    public partial class dersOrt : Form
    {
        double ortalamaNot;
        bool yuzdekontrolu= true;
        public dersOrt()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;

            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;

            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            textBox1.Text = "Final";
            textBox2.Text = "Vize";
            textBox3.Text = "Laboratuvar";
            textBox4.Text = "Not 3";
            textBox5.Text = "Not 2";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            switch (comboBox1.Text)
            {
                case "2" :
                    textBox1.Visible = true;
                    textBox6.Visible = true;
                    textBox15.Visible = true;
                    textBox2.Visible = true;
                    textBox7.Visible = true;
                    textBox14.Visible = true;

                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;
                    textBox12.Visible = false;
                    textBox13.Visible = false;
                   
                    textBox15.Text = "60";
                    textBox14.Text = "40";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    break;
                case "3":
                    textBox1.Visible = true;
                    textBox6.Visible = true;
                    textBox15.Visible = true;
                    textBox2.Visible = true;
                    textBox7.Visible = true;
                    textBox14.Visible = true;
                    textBox3.Visible = true;
                    textBox8.Visible = true;
                    textBox13.Visible = true;

                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox12.Visible = false;
                    textBox11.Visible = false;

                    textBox15.Text = "50";
                    textBox14.Text = "25";
                    textBox13.Text = "25";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    
                    break;
                case "4":
                    textBox1.Visible = true;
                    textBox6.Visible = true;
                    textBox15.Visible = true;
                    textBox2.Visible = true;
                    textBox7.Visible = true;
                    textBox14.Visible = true;
                    textBox3.Visible = true;
                    textBox8.Visible = true;
                    textBox13.Visible = true;
                    textBox4.Visible = true;
                    textBox9.Visible = true;
                    textBox12.Visible = true;

                    textBox5.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    textBox15.Text = "40";
                    textBox14.Text = "20";
                    textBox13.Text = "20";
                    textBox12.Text = "20";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    
                    break;
                case "5":
                    textBox1.Visible = true;
                    textBox6.Visible = true;
                    textBox15.Visible = true;
                    textBox2.Visible = true;
                    textBox7.Visible = true;
                    textBox14.Visible = true;
                    textBox3.Visible = true;
                    textBox8.Visible = true;
                    textBox13.Visible = true;
                    textBox4.Visible = true;
                    textBox9.Visible = true;
                    textBox12.Visible = true;
                    textBox5.Visible = true;
                    textBox10.Visible = true;
                    textBox11.Visible = true;

                    textBox15.Text = "40";
                    textBox14.Text = "20";
                    textBox13.Text = "20";
                    textBox12.Text = "10";
                    textBox11.Text = "10";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] not = new double[5,5]; 
            if (comboBox1.Text=="2")
            {
                not[0, 0] = Convert.ToInt32(textBox6.Text);
                not[0, 1] = Convert.ToInt32(textBox15.Text);
                not[1, 0] = Convert.ToInt32(textBox7.Text);
                not[1, 1] = Convert.ToInt32(textBox14.Text);
                ortalamaNot = ((not[0, 0] * not[0, 1]) + (not[1, 0] * not[1, 1])) / 100;
                harfNotuBelirle();
            }
            else if (comboBox1.Text == "3")
            {
                not[0, 0] = Convert.ToInt32(textBox6.Text);
                not[0, 1] = Convert.ToInt32(textBox15.Text);
                not[1, 0] = Convert.ToInt32(textBox7.Text);
                not[1, 1] = Convert.ToInt32(textBox14.Text);
                not[2, 0] = Convert.ToInt32(textBox8.Text);
                not[2, 1] = Convert.ToInt32(textBox13.Text);
                ortalamaNot = ((not[0, 0] * not[0, 1]) + (not[1, 0] * not[1, 1]) + (not[2, 0] * not[2, 1])) / 100;
                harfNotuBelirle();
            }
            else if (comboBox1.Text == "4")
            {
                not[0, 0] = Convert.ToInt32(textBox6.Text);
                not[0, 1] = Convert.ToInt32(textBox15.Text);
                not[1, 0] = Convert.ToInt32(textBox7.Text);
                not[1, 1] = Convert.ToInt32(textBox14.Text);
                not[2, 0] = Convert.ToInt32(textBox8.Text);
                not[2, 1] = Convert.ToInt32(textBox13.Text);
                not[3, 0] = Convert.ToInt32(textBox9.Text);
                not[3, 1] = Convert.ToInt32(textBox12.Text);
                ortalamaNot = ((not[0, 0] * not[0, 1]) + (not[1, 0] * not[1, 1]) + (not[2, 0] * not[2, 1])+ (not[3, 0] * not[3, 1])) / 100;
                harfNotuBelirle();
            }
            else if (comboBox1.Text == "5")
            {
                not[0, 0] = Convert.ToInt32(textBox6.Text);
                not[0, 1] = Convert.ToInt32(textBox15.Text);
                not[1, 0] = Convert.ToInt32(textBox7.Text);
                not[1, 1] = Convert.ToInt32(textBox14.Text);
                not[2, 0] = Convert.ToInt32(textBox8.Text);
                not[2, 1] = Convert.ToInt32(textBox13.Text);
                not[3, 0] = Convert.ToInt32(textBox9.Text);
                not[3, 1] = Convert.ToInt32(textBox12.Text);
                not[4, 0] = Convert.ToInt32(textBox10.Text);
                not[4, 1] = Convert.ToInt32(textBox11.Text);
                ortalamaNot = ((not[0, 0] * not[0, 1]) + (not[1, 0] * not[1, 1]) + (not[2, 0] * not[2, 1]) + (not[3, 0] * not[3, 1])+ (not[4, 0] * not[4, 1])) / 100;
                harfNotuBelirle();
            }
            
            yüzdeKontrolü();
            if (yuzdekontrolu)
            {
                labelNot.Text = Convert.ToString(ortalamaNot);
            }
        }

        private void dersOrt_Load(object sender, EventArgs e)
        {

        }

        private void labelNot_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void harfNotuBelirle()            
        {
            int final = Convert.ToInt32(textBox6.Text);
            if ((ortalamaNot < 40 && ortalamaNot >= 0) || final<40)
            {
                label8.Text = "FF";
            }
            else if (ortalamaNot < 50 && ortalamaNot >= 40)
            {
                label8.Text = "DD";
            }
            else if (ortalamaNot < 50 && ortalamaNot >= 40)
            {
                label8.Text = "DD";
            }
            else if (ortalamaNot < 60 && ortalamaNot >= 50)
            {
                label8.Text = "DC";
            }
            else if (ortalamaNot < 70 && ortalamaNot >= 60)
            {
                label8.Text = "CC";
            }
            else if (ortalamaNot < 75 && ortalamaNot >= 70)
            {
                label8.Text = "CB";
            }
            else if (ortalamaNot < 80 && ortalamaNot >= 75)
            {
                label8.Text = "BB";
            }
            else if (ortalamaNot < 90 && ortalamaNot >= 80)
            {
                label8.Text = "BA";
            }
            else if (ortalamaNot <= 100 && ortalamaNot >= 90)
            {
                label8.Text = "AA";
            }
            else
            {
                MessageBox.Show("Not ortalamanız 0-100 arasında olmalıdır!");
            }
        }
        public void yüzdeKontrolü()
        {
            if (comboBox1.Text == "5" && (Convert.ToInt32(textBox11.Text)+Convert.ToInt32(textBox12.Text)+ Convert.ToInt32(textBox13.Text)+ Convert.ToInt32(textBox14.Text)+ Convert.ToInt32(textBox15.Text)!=100))
            {
                MessageBox.Show("Etkileme yüzdelerinin toplamı 100 olmalıdır!");
                yuzdekontrolu = false;
            }
            else if (comboBox1.Text == "4" && (Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox13.Text) + Convert.ToInt32(textBox14.Text) + Convert.ToInt32(textBox15.Text) != 100))
            {
                MessageBox.Show("Etkileme yüzdelerinin toplamı 100 olmalıdır!");
                yuzdekontrolu = false;
            }
            else if(comboBox1.Text == "3" && (Convert.ToInt32(textBox13.Text) + Convert.ToInt32(textBox14.Text) + Convert.ToInt32(textBox15.Text) != 100))
            {
                MessageBox.Show("Etkileme yüzdelerinin toplamı 100 olmalıdır!");
                yuzdekontrolu = false;
            }
            else if (comboBox1.Text == "2" && (Convert.ToInt32(textBox14.Text) + Convert.ToInt32(textBox15.Text) != 100))
            {
                MessageBox.Show("Etkileme yüzdelerinin toplamı 100 olmalıdır!");
                yuzdekontrolu = false;
            }
        }

        private void dersOrt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
