using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Recipe_Management_Project
{
    public partial class Chef_Profile : Form
    {
        SqlConnection conn;
        static string id;
        public Chef_Profile()
        {
            InitializeComponent();
        }
        public void get_chefid(string id)
        {
            Chef_Profile.id = id;
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

        private void Chef_Profile_Load(object sender, EventArgs e)
        {
            //no. of followers not being displayed
            connectDB();
            string query = "select * from chef where chef_id ="+int.Parse(Chef_Profile.id)+";";
            string q2 = "select count(*) as num_followers from follow group by chef_id having chef_id =" + int.Parse(Chef_Profile.id) + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(q2, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                textBox2.Text = dr.GetInt32(0).ToString();
                textBox1.Text = dr.GetString(1);
                textBox3.Text = dr.GetString(3);
                textBox4.Text = dr.GetString(2);
                dr.Close();
                dr = cmd2.ExecuteReader();
                dr.Read();
                textBox5.Text = dr.GetInt32(0).ToString();
                dr.Close();
            }
            catch (Exception ex) { }
            
            
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Reset_Chef_Password reset_Chef_Password = new Reset_Chef_Password();
            this.Hide();
            reset_Chef_Password.get_chefid(Chef_Profile.id);
            reset_Chef_Password.Show();
        }
    }
}
