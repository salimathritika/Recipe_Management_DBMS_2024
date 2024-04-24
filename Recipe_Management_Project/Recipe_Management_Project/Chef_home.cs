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
    public partial class Chef_home : Form
    {
        SqlConnection conn;
        static string chef_id;
        public Chef_home()
        {
            InitializeComponent();
        }
        public void get_chefid(string id)
        {
            Chef_home.chef_id = id;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_Upload chef_Upload = new Chef_Upload();
            chef_Upload.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chef_Profile profile = new Chef_Profile();
            profile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_Login login = new Chef_Login();
            login.Show();
        }

        private void Chef_home_Load(object sender, EventArgs e)
        {
            connectDB();
            // string q = "select recipe.recipe_id,dish.dish_name,diff_lvl,dish.description,cooking_instructions,cooking_time,date_of_upload,no_of_likes,avg(rating) as avg_rating from recipe join dish on recipe.dish_id=dish.dish_id join total_likes t on t.recipe_id=recipe.recipe_id join likes on recipe.recipe_id=likes.recipe_id where chef_id =5group by recipe.recipe_id,dish.dish_name,diff_lvl,dish.description,cooking_instructions,cooking_time,date_of_upload,no_of_likes; where chef_id =" + Chef_home.chef_id + ";";
            string q = "select recipe.recipe_id,dish.dish_name,diff_lvl,dish.description,cooking_instructions,cooking_time,date_of_upload,no_of_likes,avg(rating) as avg_rating from recipe join dish on recipe.dish_id=dish.dish_id join total_likes t on t.recipe_id=recipe.recipe_id join likes on recipe.recipe_id=likes.recipe_id where chef_id =" + Chef_home.chef_id + "group by recipe.recipe_id,dish.dish_name,diff_lvl,dish.description,cooking_instructions,cooking_time,date_of_upload,no_of_likes;";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rid;
            rid = textBox1.Text;
            Chef_Edit_Recipe chef_Edit_Recipe = new Chef_Edit_Recipe();
            chef_Edit_Recipe.get_id(rid, Chef_home.chef_id);
            this.Hide();
            chef_Edit_Recipe.Show();
        }
    }
}
