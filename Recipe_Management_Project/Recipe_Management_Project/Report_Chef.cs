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
    public partial class Report_Chef : Form
    {
        SqlConnection conn;
        static string r_id, u_id;
        public Report_Chef()
        {
            InitializeComponent();
        }
        public void get_id(string r_id, string u_id)
        {
            Report_Chef.r_id = r_id;
            Report_Chef.u_id = u_id;
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
        private void Report_Chef_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectDB();
            string query = "insert into report values(" + Report_Chef.u_id + "," + Report_Chef.r_id + ",'" + textBox1.Text + "');";
            SqlCommand cmd= new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
