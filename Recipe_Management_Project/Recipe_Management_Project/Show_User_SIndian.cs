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
    public partial class Show_User_SIndian : Form
    {
        SqlConnection conn;
        public Show_User_SIndian()
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
               // MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }
        private void Show_User_SIndian_Load(object sender, EventArgs e)
        {
            connectDB();
            string q = "select dish_id,dish_name,cuisine.cuisine_name,description,diet_type from dish join cuisine on dish.cuisine_id=cuisine.cuisine_id where cuisine.cuisine_name like 'south indian';";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cuisine cuisine = new Cuisine();
            cuisine.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Show_User_Recipes show_User_Recipes = new Show_User_Recipes();
                show_User_Recipes.get_id(textBox1.Text);
                show_User_Recipes.Show();
            }
            else
                MessageBox.Show("Enter a dish id");
        }
    }
}
