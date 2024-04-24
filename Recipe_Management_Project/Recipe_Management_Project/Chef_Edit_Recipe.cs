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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recipe_Management_Project
{
    public partial class Chef_Edit_Recipe : Form
    {
        static string r_id, chef_id;
        SqlConnection conn;
        public Chef_Edit_Recipe()
        {
            InitializeComponent();
        }

        public void get_id(string rid, string cid)
        {
            Chef_Edit_Recipe.chef_id = cid;
            Chef_Edit_Recipe.r_id = rid;
        }
        public void connectDB()
        {
            string connectString = "Data Source= DESKTOP-6KCKS2K\\SQLEXPRESS; Initial Catalog=recipe_management;Integrated security=True";
            conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                //MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_home chef_Home = new Chef_home();
            chef_Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectDB();
            int lvl;
            if (!int.TryParse(textBox1.Text, out lvl))
            {
                MessageBox.Show("Invalid difficulty level. Please enter a valid integer.");
                conn.Close();
            }
            else if(lvl>10 || lvl<1)
            {
                MessageBox.Show("Difficulty level not in range. Please enter a valid integer.");
                conn.Close();
            }
            else
            {
                string query = "update recipe set diff_lvl=" + textBox1.Text + " where recipe_id=" + Chef_Edit_Recipe.r_id + " and chef_id=" + Chef_Edit_Recipe.chef_id + ";";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated difficulty level");
                conn.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectDB();
            string query = "update recipe set cooking_instructions='" + textBox2.Text + "' where recipe_id=" + Chef_Edit_Recipe.r_id + " and chef_id=" + Chef_Edit_Recipe.chef_id + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated cooking instructions");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connectDB();
            int time;
            if (!int.TryParse(textBox3.Text, out time))
            {
                MessageBox.Show("Invalid cooking time. Please enter a valid integer.");
                conn.Close();
            }
            else
            {
                string query = "update recipe set cooking_time=" + textBox3.Text + " where recipe_id=" + Chef_Edit_Recipe.r_id + " and chef_id=" + Chef_Edit_Recipe.chef_id + ";";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated cooking time");
                conn.Close();
            }
            
        }
    }
}
