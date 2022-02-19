using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear(); //for clear comboBox
            comboBox1.Items.Add(textBox1.Text);//add text from textBox1 to comboBox1
            textBox1 .Text = dateTimePicker1.Value.ToLongDateString ();//video125
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)//video 126
        {
            webBrowser1.Navigate(comboBox2.Text );
        }
    }
}
