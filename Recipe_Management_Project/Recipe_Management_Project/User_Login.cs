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

namespace Recipe_Management_Project
{
    public partial class User_Login : Form
    {
        SqlConnection conn;
        public User_Login()
        {
            InitializeComponent();
        }
        public void connectDB()
        {
            string connectString = "Data Source= DESKTOP-6KCKS2K\\SQLEXPRESS; Initial Catalog=recipe_management;Integrated security=True";
            conn = new SqlConnection(connectString);
            try
            {
                conn.Open ();
               // MessageBox.Show("Connection established");
            }
            catch(Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Signup frm = new User_Signup();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Profile frm = new User_Profile();
            frm.get_userid(textBox1.Text);
            Cuisine cuisine1 = new Cuisine();
            cuisine1.get_uid(textBox1.Text);
            Show_User_Recipes show_User_Recipes = new Show_User_Recipes();
            show_User_Recipes.get_uid(textBox1.Text);
            connectDB();
              string query = "Select * from user# where user_id=" +textBox1.Text+ " and password='" + textBox2.Text + "';";
              SqlCommand cmd = new SqlCommand(query,conn);
              DataTable dt=new DataTable();
              SqlDataAdapter da=new SqlDataAdapter(cmd);
              try
              {
                  da.Fill(dt);
              }
              catch(Exception ex) { }

              if (dt.Rows.Count > 0)
              {
                  MessageBox.Show("Login successful");
                  conn.Close();
                  this.Hide();
                  Cuisine cuisine = new Cuisine();
                  cuisine.Show();
              }
              else
                  MessageBox.Show("Try again");  

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mode_Select frm = new Mode_Select();
            frm.Show();
        }
    }
}
