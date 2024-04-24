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
    public partial class Reset_Chef_Password : Form
    {
        SqlConnection conn;
        string id;
        public Reset_Chef_Password()
        {
            InitializeComponent();
        }
        public void get_chefid(string id)
        {
            this.id = id;
        }
        public void connectDB()
        {
            string connectString = "Data Source= DESKTOP-6KCKS2K\\SQLEXPRESS; Initial Catalog=recipe_management;Integrated security=True";
            conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                //MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectDB();
            string query = "update chef set password ='" + textBox2.Text + "' where chef_id=" + int.Parse(id) + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Password has been reset");
            this.Hide();
            Chef_Profile profile = new Chef_Profile();
            profile.Show();
        }

        private void Reset_Chef_Password_Load(object sender, EventArgs e)
        {
            textBox1.Text = id;
        }
    }
}
