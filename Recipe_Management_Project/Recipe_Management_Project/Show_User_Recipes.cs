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
        static string d_id, u_id,dlvl="0",rate="0",num_likes="0";

        public Show_User_Recipes()
        {
            InitializeComponent();
        }

        public void filtered(string nl,string r,string dl)
        {
            Show_User_Recipes.num_likes = nl;
            Show_User_Recipes.rate = r;
            Show_User_Recipes.dlvl = dl;
        }
        public void get_id(string did)
        {
            Show_User_Recipes.d_id = did;
        }
        public void get_uid(string uid)
        {
            Show_User_Recipes.u_id = uid;
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
            string q = "select recipe_id,diff_lvl,cooking_instructions,cooking_time from recipe  where dish_id=" + Show_User_Recipes.d_id + ";";
            //and diff_lvl>"+ Show_User_Recipes.dlvl + " and no_of_likes>="+ Show_User_Recipes.dlvl + ";";
            //join total_likes on recipe.recipe_id=total_likes.recipe_id
            //,no_of_likes
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Detailed_Recipe show_Detailed_Recipe = new Show_Detailed_Recipe();
            show_Detailed_Recipe.get_id(textBox1.Text, Show_User_Recipes.u_id);
            show_Detailed_Recipe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
