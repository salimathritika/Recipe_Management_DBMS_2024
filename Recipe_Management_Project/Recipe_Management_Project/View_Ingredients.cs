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
    public partial class View_Ingredients : Form
    {
        SqlConnection conn;
        static string rid;
        public View_Ingredients()
        {
            InitializeComponent();
        }
        public void get_rid(string rid)
        {
            View_Ingredients.rid = rid;
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
        private void View_Ingredients_Load(object sender, EventArgs e)
        {
            connectDB();
            string q = "select ingredient_name,quantity from ingredients join recipeingredients on ingredients.ingredient_id=recipeingredients.ingredient_id where recipe_id="+ View_Ingredients.rid + ";";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
