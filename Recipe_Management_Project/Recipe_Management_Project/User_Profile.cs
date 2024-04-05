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
    public partial class User_Profile : Form
    {
        public User_Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset_User_Password reset_User_Password = new Reset_User_Password();
            reset_User_Password.Show();
        }

        private void User_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
