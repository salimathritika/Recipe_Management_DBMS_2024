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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_All show_User_All = new Show_User_All();
            show_User_All.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_Beverages show_User_bvg = new Show_User_Beverages();
            show_User_bvg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_Italian show_User_ita = new Show_User_Italian();
            show_User_ita.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_Mexican show_User_mex = new Show_User_Mexican();
            show_User_mex.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_SIndian show_User_sind = new Show_User_SIndian();
            show_User_sind.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_NIndian show_User_nind = new Show_User_NIndian();
            show_User_nind.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_Chinese show_User_chin = new Show_User_Chinese();
            show_User_chin.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_User_Korean show_User_kor = new Show_User_Korean();
            show_User_kor.Show();
        }
    }
}
