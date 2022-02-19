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
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }
        public RichTextBox textcontrol
        {
            get { return richTextBox1; }
            set { richTextBox1 = value; }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // label = "nochar";vido116
          (this.MdiParent as FrmMain ) . nochar = richTextBox1.TextLength.ToString() ; //ضع نتيجة تنفيذ هذة-العمليةالتي على اليمين- في صفحة الجايلد ضعها النتيجة في المين فريم
          (this.MdiParent as FrmMain ) . noline = richTextBox1.Lines.Length.ToString();
        }
    }
}
