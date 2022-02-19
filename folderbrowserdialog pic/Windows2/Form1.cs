using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Windows2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List <string> l = new List<string> () ; //defeind list 
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();//to display folderbrowserdialog on the secreen(it open trak(for folders on PC))
            string [] s = Directory.GetFiles (folderBrowserDialog1.SelectedPath ) ;//choess trak files from folderbrowser & put it in function GetFiles & put in array s.
             foreach (string item in s )//display items s in listBox1 have many method for display
             {
                 if (!(Path.GetExtension(item) == ".ini") && !(Path.GetExtension(item) == ".db")) //excpition extension .ini && .db
                 { //listBox1.Items.Add(item);
                     listBox1.Items.Add(Path.GetFileNameWithoutExtension(item));
                     l.Add(Path.GetFullPath(item));     //list(type of array to save Path item);
                 }
             }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(l[listBox1.SelectedIndex ]);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom ;
        }
    }
}
