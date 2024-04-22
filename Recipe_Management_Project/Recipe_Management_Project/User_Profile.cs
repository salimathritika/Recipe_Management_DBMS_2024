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
    public partial class User_Profile : Form
    {
        SqlConnection conn;
        static string id;
        public User_Profile()
        {
            InitializeComponent();
        }
        public void get_userid(string id)
        {
            User_Profile.id = id;
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
            Reset_User_Password reset_User_Password = new Reset_User_Password();
            this.Hide();
            reset_User_Password.get_userid(User_Profile.id);
            reset_User_Password.Show();
        }

        private void User_Profile_Load(object sender, EventArgs e)
        {
            //need to display allergens also
            connectDB();
            string query = "select * from user# where user_id =" + int.Parse(User_Profile.id) + ";";
            //string q2 = "select count(*) as num_followers from follow group by chef_id having chef_id =" + int.Parse(Chef_Profile.id) + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
           // SqlCommand cmd2 = new SqlCommand(q2, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                textBox2.Text = dr.GetInt32(0).ToString();
                textBox1.Text = dr.GetString(1);
                textBox3.Text = dr.GetString(4);
                textBox4.Text = dr.GetString(3);
                textBox5.Text = dr.GetString(2);
            //    dr = cmd2.ExecuteReader();
            //    dr.Read();
            //    textBox5.Text = dr.GetInt32(0).ToString();
            }
            catch (Exception ex) { }


            conn.Close();
        }
    }
}
