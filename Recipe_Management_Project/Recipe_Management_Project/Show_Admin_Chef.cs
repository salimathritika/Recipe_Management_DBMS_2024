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
    public partial class Show_Admin_Chef : Form
    {
        SqlConnection conn;
        public Show_Admin_Chef()
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
                //MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }

        private void Show_Admin_Chef_Load(object sender, EventArgs e)
        {
            connectDB();
            string q = "select * from chef";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectDB();
            string query = "delete from chef where chef_id=" + textBox1.Text + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chef deleted");
            this.Hide();
            Show_Admin_Chef show_Admin_chef = new Show_Admin_Chef();
            show_Admin_chef.Show();
            conn.Close();
        }
    }
}
