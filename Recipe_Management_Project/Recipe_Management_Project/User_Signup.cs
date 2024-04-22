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
    public partial class User_Signup : Form
    {
        SqlConnection conn;
        String name, country, diet, pswd,id;
        public User_Signup()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            name= textBox2.Text;
            country= textBox4.Text;
            diet= textBox5.Text;
            pswd= textBox3.Text;
            connectDB();
            string query = "insert into user# values ("+id+",'"+name+"','"+diet.ToLower()+"','"+country+"','"+pswd+"');";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            
            if(textBox6.Text.Length > 0 )
            {
                string q2 = "insert into userallergens values (" + id + ",'" + textBox6.Text + "');";
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                cmd2.ExecuteNonQuery();
            }
            if (textBox7.Text.Length > 0)
            {
                string q3 = "insert into userallergens values (" + id + ",'" + textBox7.Text + "');";
                SqlCommand cmd3 = new SqlCommand(q3, conn);
                cmd3.ExecuteNonQuery();
            }
            if (textBox8.Text.Length > 0)
            {
                string q4 = "insert into userallergens values (" + id + ",'" + textBox8.Text + "');";
                SqlCommand cmd4 = new SqlCommand(q4, conn);
                cmd4.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Inserted");
            this.Hide();
        }
    }
}
