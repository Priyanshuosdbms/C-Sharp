using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackEndDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-7KE8K8N\\SQLEXPRESS;Initial Catalog=priyanshu;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                string firstName = textBox1.Text;
                string secondName = textBox2.Text;  // Change the variable name here

                string query = "INSERT INTO Names(FirstName, SecondName) VALUES (@FirstName, @SecondName)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@SecondName", secondName);  // Change the parameter name here

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-7KE8K8N\\SQLEXPRESS;Initial Catalog=priyanshu;Integrated Security=True";

            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                string firstName = textBox1.Text;
                string secondName = textBox2.Text;

                string query = "DELETE FROM Names WHERE FirstName = @FirstName AND SecondName = @SecondName";


                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName); // delete's syntax
                    cmd.Parameters.AddWithValue("@SecondName", secondName);

                    cmd.ExecuteNonQuery();

                }
            }

            MessageBox.Show("Data Has Been Deleted");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-7KE8K8N\\SQLEXPRESS;Initial Catalog=priyanshu;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                string query = "SELECT *FROM Names SORT";

                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been Sorted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-7KE8K8N\\SQLEXPRESS;Initial Catalog=priyanshu;Integrated Security=True";

            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
            }
        }
    }
}
