using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_word
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        // here we make public properties for lbl_line&lbl_char(becaues we call him in FrmChild(only public));video 115
        public string nochar
        {
            set { lbl_char.Text = value ; }// here we ues set to put value in lbl( get not use not have print);
        }
        public string noline
        {
            set { lbl_line.Text = value ; }// here we ues set to put value in lbl( get not use not have print);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChild c = new FrmChild () ;//make object c from class FrmChild;
            c.MdiParent = this;  //c his father FrmMain or c display in FrmMain(this=plaes where you work here FrmMain)
            c.Show();//display on screen;
        }

        private void arrange_click(object sender, EventArgs e)
        {
            if (sender == verticalToolStripMenuItem)
            {
                this .LayoutMdi (MdiLayout.TileVertical) ;
            }
            if (sender == horzintialToolStripMenuItem)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal );
            }
            if (sender == cascadeToolStripMenuItem )
            {
                this.LayoutMdi(MdiLayout.Cascade );
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToLongTimeString();//after add timer we change properties & dobleclick event have tick to open tis function;  
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "document|.txt" ; //for determin type save;رvideo 118

            DialogResult res = saveFileDialog1.ShowDialog();// to display (use) saveFileDialog1

            FrmChild child = this.ActiveMdiChild  as FrmChild  ;//هنا نحن نعمل تخزين من المين على نافذة الجايلد فنعتبر المين كانة جايلد ونخزنه في اوبجكت جايلدمن نوع فريم جايلد
            
            if (res == DialogResult .OK ) //if Cansel not work anything
            {
                child.textcontrol.SaveFile(saveFileDialog1.FileName);//لاحظ فايل نيم ياخذاسم مسار ويضعه في سيففايل دايلوك الذي سوف يقوم باعظاء القيم لدالة التيكست كونترول ويخزن في الاوبجت جايلد ومن خلال سيففايلديلوك يخزن على الهارد
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)//video119 same up
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if ( res == DialogResult.OK)
            {
                FrmChild child = new FrmChild();
                child.MdiParent = this;
                child.Show();
                child.textcontrol.LoadFile(openFileDialog1.FileName);
            }
        }

        private void edit(object sender, EventArgs e) //vidoe 120 cut copy paste
        {
            FrmChild child = this.ActiveMdiChild as FrmChild;
            if (sender == cutToolStripMenuItem)
            {
                child.textcontrol.Cut();
            }
            if (sender == copyToolStripMenuItem)
            {
                child.textcontrol.Copy();
            }
            if (sender == pasteToolStripMenuItem)
            {
                child.textcontrol.Paste();
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)//vidoe 121 right click menu
        {
            FrmChild child = this.ActiveMdiChild as FrmChild;
            if (sender == cutToolStripMenuItem1)
            {
                child.textcontrol.Cut();
            }
            if (sender == copyToolStripMenuItem1)
            {
                child.textcontrol.Copy();
            }
            if (sender == pasteToolStripMenuItem1)
            {
                child.textcontrol.Paste();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)//vidoe 122 font menu
        {
            fontDialog1.ShowDialog();
            FrmChild child = this.ActiveMdiChild  as FrmChild;
            child.textcontrol.SelectionFont = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)//vidoe 123 color menu
        {
            colorDialog1.ShowDialog();
            FrmChild child = this.ActiveMdiChild as FrmChild;
            child.textcontrol.SelectionColor = colorDialog1.Color;
        }
    }
}
