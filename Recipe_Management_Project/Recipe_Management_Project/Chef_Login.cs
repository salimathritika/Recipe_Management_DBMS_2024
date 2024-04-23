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
    public partial class Chef_Login : Form
    {
        SqlConnection conn;
        public Chef_Login()
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
            Chef_Signup chef_Signup = new Chef_Signup();
            chef_Signup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chef_Profile chef_Profile = new Chef_Profile();
            chef_Profile.get_chefid(textBox1.Text);
            Chef_home frm=new Chef_home();
            frm.get_chefid(textBox1.Text);
            connectDB();
            string query = "Select * from chef where chef_id=" + textBox1.Text + " and password='" + textBox2.Text + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex) { }

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successful");
                conn.Close();
                this.Hide();
                Chef_home chef_Home = new Chef_home();
                chef_Home.Show();
            }
            else
                MessageBox.Show("Try again");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mode_Select frm = new Mode_Select();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chef_Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
