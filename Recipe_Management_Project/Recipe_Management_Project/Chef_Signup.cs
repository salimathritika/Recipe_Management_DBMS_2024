using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Management_Project
{
    public partial class Chef_Signup : Form
    {
        SqlConnection conn;
        string id, name, country, pswd;
        public Chef_Signup()
        {
            InitializeComponent();
        }
        public void connectDB()
        {
            string connectString = "Data Source= DESKTOP-6KCKS2K\\SQLEXPRESS; Initial Catalog=recipe_management;Integrated security=True";
            conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name=textBox2.Text;
            id=textBox1.Text;
            country=textBox4.Text;
            pswd=textBox3.Text;
            connectDB();
            string query = "insert into chef values (" + id + ",'" + name + "','" + country + "','" + pswd + "');";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Inserted");
            this.Hide();

        }
    }
}
