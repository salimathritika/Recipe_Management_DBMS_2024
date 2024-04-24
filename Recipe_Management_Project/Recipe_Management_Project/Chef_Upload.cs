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
        static string did, rid, dlvl, ci, ct, chef_id;
        public Chef_Upload()
        {
            InitializeComponent();
        }
        public void get_chef_id(string id)
        {
            Chef_Upload.chef_id = id;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Chef_Upload.did = textBox1.Text;
            Chef_Upload.rid = textBox2.Text;
            Chef_Upload.dlvl = textBox3.Text;
            Chef_Upload.ci = textBox4.Text;
            Chef_Upload.ct = textBox5.Text;
            int time; int lvl;
            if (!int.TryParse(Chef_Upload.ct, out time))
            {
                MessageBox.Show("Invalid cooking time. Please enter a valid integer.");

            }


            else if (!int.TryParse(textBox1.Text, out lvl))
            {
                MessageBox.Show("Invalid difficulty level. Please enter a valid integer.");

            }

            else
            {
                connectDB();
                string q = "insert into recipe values (" + Chef_Upload.rid + ", " + Chef_Upload.did + ", " + Chef_Upload.chef_id + ", " + Chef_Upload.dlvl + ", '" + Chef_Upload.ci + "', '2024-04-24', " + Chef_Upload.ct + ");";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Recipe Inserted");
                cmd.Dispose();
                conn.Close();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nutritional_values_add nutritional_Values_Add = new Nutritional_values_add();
            nutritional_Values_Add.get_rid(textBox2.Text);
            nutritional_Values_Add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_home chef_Home = new Chef_home();
            chef_Home.Show();
        }
    }
}
