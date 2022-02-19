using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold ;
            pictureBox1.Image = new Bitmap("f:\\g.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "God";
            textBox1.Text  = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "this work";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked == true)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)   ///button for opendialog
        {   l:
            openFileDialog1.Title = "open your pic pls";        //Title for opendialog
            openFileDialog1.Filter = "image|*.jpg";             //Filter for image
            DialogResult res = openFileDialog1.ShowDialog();     // res = what you image choess
            if (res == DialogResult.OK)                 
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);  // if you choess image & press Ok display image in pictuerBox1
            }
            else           ///in Cansel will appear message
            {//use message very very good
              DialogResult res1 = MessageBox.Show("you want exit ","Shot messge", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);//if Cansel will return to Dialog
                                                        //res1 result press OK or Cansel
            if ( res1 == DialogResult.Cancel)
            {
                goto l; //will return to openDialog
            }
            }
        }
    }
}
