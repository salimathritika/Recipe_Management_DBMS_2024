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
    public partial class Chef_Profile : Form
    {
        public Chef_Profile()
        {
            InitializeComponent();
        }

        private void Chef_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset_Chef_Password reset_Chef_Password = new Reset_Chef_Password();
            reset_Chef_Password.Show();
        }
    }
}
