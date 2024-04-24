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
    public partial class User_Review_Dish : Form
    {
        SqlConnection conn;
        static string u_id, r_id;
        public User_Review_Dish()
        {
            InitializeComponent();
        }

        public void get_id(string u_id, string r_id)
        {
            User_Review_Dish.u_id = u_id;
            User_Review_Dish.r_id = r_id;
        }
        public void connectDB()
        {
            string connectString = "Data Source= DESKTOP-6KCKS2K\\SQLEXPRESS; Initial Catalog=recipe_management;Integrated security=True";
            conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
               // MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rate;
            if (!int.TryParse(textBox1.Text, out rate))
            {
                MessageBox.Show("Invalid rating. Please enter a valid integer.");
            }
            else if(rate<0 || rate>5)
            {
                MessageBox.Show("Rating is out of range. Please enter in the range of 0-5.");
            }
            
            else 
            {
                connectDB();
                string query = "insert into likes values("+ User_Review_Dish.u_id + ","+ User_Review_Dish.r_id + ","+textBox1.Text+",'"+textBox2.Text+"'); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
