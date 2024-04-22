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
    public partial class Chef_home : Form
    {
        SqlConnection conn;
        public Chef_home()
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chef_Profile profile = new Chef_Profile();
            profile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_Login login = new Chef_Login();
            login.Show();
        }
    }
}
