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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AGNO_Click(object sender, EventArgs e)
        {
            this.Hide();
            donemOrt nsn = new donemOrt();
            nsn.Show();
            
        }

        private void DersOrt_Click(object sender, EventArgs e)
        {
            dersOrt nsn = new dersOrt();
            nsn.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ogr.kocaeli.edu.tr/koubs/ogrenci/index.cfm");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://edestek3.kocaeli.edu.tr/login/index.php");
        }
    }
}
