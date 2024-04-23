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
    public partial class Admin_Login : Form
    {
        String ID = "1234";
        String pswd = "admin";
        int flag = 0;
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text == ID)
                {
                    flag++;
                }
            }
            if (textBox2.Text.Length > 0)
            {
                if (textBox2.Text == pswd)
                {
                    flag++;
                }
            }
            if (flag == 2)
            {
                MessageBox.Show("Admin has succcessfully logged in");
            }
            else
            {
                MessageBox.Show("Incorrect Credentials. Please try again");
                flag = 0;
            }
            this.Hide();
            Admin_Home frm = new Admin_Home();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mode_Select frm=new Mode_Select();
            frm.Show();
        }
    }
}
