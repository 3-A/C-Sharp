using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;

namespace ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
    private void button1_Click(object sender, EventArgs e)
        {     //1 حضر الاتصال بقاعدة البيانات
              OleDbConnection con  = new OleDbConnection( );
              con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;DataSource=|DataDirectory|/store.accdb";
              
              //2 حضر الطلب
              OleDbCommand conn = new OleDbCommand();
              conn.Connection   = con;
              conn.CommandText  = "select count (*) from emp";

              //3فتح الاتصال
              con.Open();
              MessageBox.Show(con.State.ToString());
              //4تنفيذ الامر 
             int x =Convert.ToInt32 ( conn.ExecuteScalar());
             MessageBox.Show(x.ToString());
              //5قفل الاتصال
              con.Close();
              con.Dispose();
              con = null;
    }
    }
}
