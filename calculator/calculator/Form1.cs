using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double no_1;
        Double no_2;
        string operation;
        bool b = true;
        Double sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (object b in this.Controls)
            {
                if (b is Button)
                {
                    (b as Button).Font = Properties.Settings.Default.button_font;
                    (b as Button).ForeColor = Properties.Settings.Default.button_color;
                }
            }
        }

        private void button_click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + (sender as Button).Text;
            // textBox1.Text + =  (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (b == true)            { no_1 = Convert .ToDouble (textBox1.Text); b = false; }
            else                      { no_2 = Convert.ToDouble(textBox1.Text); b = true; }

             //no_1 = Convert.ToInt32(textBox1.Text);
            if (sender == button11)
            {
                operation = "+";
            }
            else if (sender == button12)
            {
                operation = "-";
            }
            else if (sender == button13)
            {
                operation = "*";
            }
            else if (sender == button14)
            {
                operation = "/";
            }
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (b == true)            { no_1 = Convert.ToDouble(textBox1.Text); b = false; }
            else                      { no_2 = Convert.ToDouble(textBox1.Text); b = true; }

            if (operation == "+")
            {
                sum = no_1 + no_2;
            }
            else if (operation == "-")
            {
                sum = no_1 - no_2;
            }
            else if (operation == "*")
            {
                sum = no_1 * no_2;
            }
            else if (operation == "/")
            {
                sum = no_1 / no_2;
            }
            textBox1.Text = sum.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text  = "";
        }
    }
}
