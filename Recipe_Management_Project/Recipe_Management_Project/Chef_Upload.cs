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
    public partial class Chef_Upload : Form
    {
        SqlConnection conn;
        public Chef_Upload()
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
        private void Chef_Upload_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Available_Dish_ID available_Dish_ID = new Available_Dish_ID();
            available_Dish_ID.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Chef_home chef_Home = new Chef_home();
            chef_Home.Show();
        }
    }
}
