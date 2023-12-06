using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace c__project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f1 = new Form2();
            f1.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        
        

        private void button3_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=harshada\\sqlexpress;Initial Catalog=movie;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            string Q1 = "select total from book1 where id=1";
            SqlCommand c1 = new SqlCommand(Q1, con);
            int r1 = (int)c1.ExecuteScalar();
            label5.Text = "Available seats are  " + r1;
        }
    }
}
