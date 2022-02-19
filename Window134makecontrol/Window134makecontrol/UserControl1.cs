using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window134makecontrol
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        [Description("run clock or not"),Category ("user category")  ] //biuld descrip &Category for us control disapper on right in field properties
        public bool enable_clock///properties
        {
            get { return checkBox1.Checked; } // to get stetas checkBox1
            set { checkBox1.Checked = value; }// to set stetas checkBox1
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString(); //determain clock &put it in label1
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();//load  timer from up incontrol when load control
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled= checkBox1.Checked ;
        }
    }
}
