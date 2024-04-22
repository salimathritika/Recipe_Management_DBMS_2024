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
    public partial class Cuisine : Form
    {
        SqlConnection conn;
        public Cuisine()
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

        private void button10_Click(object sender, EventArgs e)
        {
            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login login = new User_Login();
            login.Show();
        }
    }
}
