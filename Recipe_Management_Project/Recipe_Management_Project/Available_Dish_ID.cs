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
    public partial class Available_Dish_ID : Form
    {
        SqlConnection conn;
        public Available_Dish_ID()
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

        private void Available_Dish_ID_Load(object sender, EventArgs e)
        {
            connectDB();
            string q = "select dish_id,dish_name,cuisine_name,description,diet_type from dish join cuisine on dish.cuisine_id=cuisine.cuisine_id;";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Length! > 0 || textBox2.Text.Length! > 0 || textBox3.Text.Length! > 0 || textBox4.Text.Length! > 0 || textBox5.Text.Length! > 0)
            {
                MessageBox.Show("Enter all values");
            }
            else
            {*/

            //NOT sure if it works
                string did, dname, cuisine, desc, diet, cid="0";
                did = textBox1.Text;
                dname = textBox2.Text;
                cuisine = textBox3.Text;
                desc = textBox4.Text;
                diet = textBox5.Text;
                connectDB();
                string q1 = "select cuisine_id from cuisine where cuisine_name='" + cuisine.ToLower() + "';";
                SqlCommand cmd = new SqlCommand(q1, conn);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    cid = dr.GetInt32(0).ToString();
                    dr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex) { }
                string q2 = "insert into dish values(" + did + ",'" + dname + "'," + cid + ",'" + desc + "','" + diet + "');";
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                conn.Close();

            
        }
    }
}
