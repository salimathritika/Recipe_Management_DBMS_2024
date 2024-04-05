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
    public partial class Chef_Login : Form
    {
        public Chef_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chef_Signup chef_Signup = new Chef_Signup();
            chef_Signup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chef_home chef_Home = new Chef_home();
            chef_Home.Show();
        }
    }
}
