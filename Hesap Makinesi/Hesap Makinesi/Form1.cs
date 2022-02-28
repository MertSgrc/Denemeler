using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
            {
                textBox1.Text = "0";
            }
            else if(optDurum)
            {
                textBox1.Text = "0";
            }
            if(!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            optDurum = false;
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || optDurum)
                textBox1.Clear();
            optDurum = false;
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void OptHesapla(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            switch(opt)
            {
                case "+": textBox1.Text = (sonuc + double.Parse(textBox1.Text)).ToString();break;
                case "-": textBox1.Text = (sonuc - double.Parse(textBox1.Text)).ToString();break;
                case "*": textBox1.Text = (sonuc * double.Parse(textBox1.Text)).ToString();break;
                case "/": textBox1.Text = (sonuc / double.Parse(textBox1.Text)).ToString();break;
            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt = yeniOpt;  

        }

        private void bSil_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void bEsit_Click(object sender, EventArgs e)
        {
            optDurum = true;
            switch(opt)
            {
                case "+":textBox1.Text = (sonuc + double.Parse(textBox1.Text)).ToString();break;
                case "-":textBox1.Text = (sonuc - double.Parse(textBox1.Text)).ToString();break;
                case "*":textBox1.Text = (sonuc * double.Parse(textBox1.Text)).ToString();break;
                case "/":textBox1.Text = (sonuc / double.Parse(textBox1.Text)).ToString();break;
            }
            sonuc = double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt = "";
        }
    }
}
