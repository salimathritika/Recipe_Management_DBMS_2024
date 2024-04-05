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
    public partial class Cuisine : Form
    {
        public Cuisine()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
        }
    }
}
