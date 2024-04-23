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
    public partial class Show_User_Recipes : Form
    {
        SqlConnection conn;
        static string d_id;
        public Show_User_Recipes()
        {
            InitializeComponent();
        }

        public void get_id(string did)
        {
            Show_User_Recipes.d_id = did;
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
        private void Show_User_Recipes_Load(object sender, EventArgs e)
        {
            connectDB();
            string q = "select recipe_id,diff_lvl,cooking_instructions,cooking_time from recipe where dish_id="+Show_User_Recipes.d_id+";";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
