using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rechner4
{
    
    public partial class Form1 : Form
    {
        private Func<double, double, double> sonislem;
        TextBox aktifTextBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox1;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox2;
        }

        private void btnSayi_Click(object sender, MouseEventArgs e)
        {
            Button tiklanan = sender as Button;

            if (aktifTextBox != null)
            {
                aktifTextBox.Text += tiklanan.Text;
            }

        }

        private void buttonsum_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            labelSonuc.Text = (sayi1 + sayi2).ToString();
            sonislem = (a, b) => a + b;
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            labelSonuc.Text = (sayi1 - sayi2).ToString();
            sonislem = (a, b) => a - b;


        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            labelSonuc.Text = (sayi1 * sayi2).ToString();
            sonislem = (a, b) => a * b;


        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            if (sayi2 != 0)
            {
                labelSonuc.Text = (sayi1 / sayi2).ToString();
                sonislem = (a, b) => b != 0 ? a / b : 0;
            }
            else
            {
                labelSonuc.Text = "0'a bölünemez!";
                sonislem = null;
            }

        }

        private void buttongleich_Click(object sender, EventArgs e)
        {
            if (sonislem != null)
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                labelSonuc.Text = sonislem(sayi1, sayi2).ToString();
            }
            else
            {
                labelSonuc.Text = "İslem seçiniz!";

            }

        }

        private void buttonlöschen_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelSonuc.Text = " ";
            sonislem = null;


        }
    }
}
