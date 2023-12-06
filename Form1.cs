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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet.a1' table. You can move, or remove it, as needed.
          //  this.a1TableAdapter.Fill(this.movieDataSet.a1);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //string Connectionstring = "Data Source=harshada\\sqlexpress;Initial Catalog=movie;Integrated Security=True";
            //SqlConnection con = new SqlConnection(Connectionstring);
            //con.Open();
            //string Query = "SELECT SUM (seat) FROM Table_1";
            //SqlCommand cmd = new SqlCommand(Query, con);
            //cmd.ExecuteNonQuery();

            int n1;
            //int n2, Q;
            double r;
            n1 = Convert.ToInt32(textBox3.Text);
            r = n1 * 300;
            label9.Text = "Total Price " + r;
            // Q = Convert.ToInt32(Query);
            //n2 = 30-Q;
            //label10.Text = " "+Query;
            string Connectionstring = "Data Source=harshada\\sqlexpress;Initial Catalog=movie;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            

            string Q1 = "select total from book1 where id=1";
            SqlCommand c1 = new SqlCommand(Q1, con);
            int r1 = (int)c1.ExecuteScalar();
            if (n1 > r1)
                MessageBox.Show("Seats available are  " +r1+"Please select seats less than or equal to "+r1);  
              

            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=harshada\\sqlexpress;Initial Catalog=movie;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            string name = textBox1.Text;
            string no = textBox2.Text;
           string p = textBox3.Text;
            int a, b;
            a = Convert.ToInt32(no);
            b = Convert.ToInt32(p);
            string Query = "INSERT INTO book1 (email,phone_no,seat) VALUES ('" + name + "'," + a + "," + b + ")";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            string Q1 = "select id from book1 where phone_no="+a+"";
            SqlCommand c1 = new SqlCommand(Q1, con);
            int r=(int)c1.ExecuteScalar();

            MessageBox.Show(" Booking ID"+r+" \n Movie name= Dream girl2\n Movie Timings= 2pm");
           


            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=harshada\\sqlexpress;Initial Catalog=movie;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            string Query1 = "update book1 set total=50-(select sum(seat) as total from book1)";
            SqlCommand cmd1 = new SqlCommand(Query1, con);
         
            cmd1.ExecuteNonQuery();
            Main f2 = new Main();
            f2.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
               

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
