using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnnnn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conn = @"provider=Microsoft.ACE.OLEDB.12.0; data source =./AppData/StudentDB.accdb";
            OleDbConnection newCon = new OleDbConnection(conn);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = newCon;
            cmd.CommandText = "Select * from Users";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //newCon.Open();


        }
    }
}
