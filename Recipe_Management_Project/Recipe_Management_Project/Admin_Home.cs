using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Management_Project
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Admin_Users show_Admin_Users = new Show_Admin_Users();
            show_Admin_Users.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login frm = new Admin_Login();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Show_Admin_Chef show_Admin_Chef = new Show_Admin_Chef();
            show_Admin_Chef.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Admin_Display_Reports show_Admin_Display_Reports = new Admin_Display_Reports();
            show_Admin_Display_Reports.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Admin_Display_Review admin_Display_Review = new Admin_Display_Review();
            admin_Display_Review.Show();
        }
    }
}
