using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recipe_Management_Project
{
    public partial class Show_Detailed_Recipe : Form
    {
        SqlConnection conn;
        static string r_id, u_id, c_id;
        public Show_Detailed_Recipe()
        {
            InitializeComponent();
        }

        public void get_id(string id, string uid)
        {
            Show_Detailed_Recipe.r_id = id;
            Show_Detailed_Recipe.u_id = uid;
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


        private void Show_Detailed_Recipe_Load(object sender, EventArgs e)
        {
            string dname, cname, dlvl, ci, ct, num_ppl, carb, fat, pro, sod, chol, sug, glu, caf,avg_r;
            connectDB();
            string query = "select dish.dish_name,chef.chef_name,diff_lvl,cooking_instructions,cooking_time from recipe join chef on recipe.chef_id=chef.chef_id join dish on recipe.dish_id=dish.dish_id where recipe_id =" + Show_Detailed_Recipe.r_id + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            string q2 = "select count(*) as num_people_tried from likes group by recipe_id having recipe_id=" + Show_Detailed_Recipe.r_id + ";";
            SqlCommand cmd2 = new SqlCommand(q2, conn);
            string q3 = "select avg(rating) as average_rate from likes group by recipe_id having recipe_id =" + Show_Detailed_Recipe.r_id + ";";
            SqlCommand cmd3 = new SqlCommand(q3, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                dname = dr.GetString(0); ;
                cname = dr.GetString(1);
                dlvl = dr.GetInt32(2).ToString();
                ci = dr.GetString(3);
                ct = dr.GetInt32(4).ToString();
                cmd.Dispose();
                dr.Close();
                dr = cmd2.ExecuteReader();
                dr.Read();
                num_ppl = dr.GetInt32(0).ToString();
                cmd2.Dispose();
                dr.Close();
                dr = cmd3.ExecuteReader();
                dr.Read();
                avg_r = dr.GetInt32(0).ToString();
                cmd3.Dispose();
                dr.Close();

                richTextBox1.Text = "Dish Name:" + dname + "\nChef Name:" + cname + "\nDifficult level of cooking:" + dlvl + "\n\nCooking instructions:\n" + ci + "\nCooking time:" + ct + " minutes\n\nNumber of people who have liked this recipe:" + num_ppl + "\nAverage rating given to this recipe:"+avg_r+"\n";
                conn.Close();
            }
            catch (Exception ex) { }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Review_Dish user_Review_Dish = new User_Review_Dish();
            user_Review_Dish.get_id(Show_Detailed_Recipe.u_id, Show_Detailed_Recipe.r_id);
            user_Review_Dish.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectDB();
            string getcid = "select chef_id from recipe where recipe_id=" + Show_Detailed_Recipe.r_id + ";";
            SqlCommand cmd = new SqlCommand(getcid, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Show_Detailed_Recipe.c_id = dr.GetInt32(0).ToString();
                dr.Close();
                cmd.Dispose();

                string query = "insert into follow values(" + Show_Detailed_Recipe.u_id + "," + Show_Detailed_Recipe.c_id + ");";
                SqlCommand cmd3 = new SqlCommand(query, conn);
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report_Chef report_Chef = new Report_Chef();
            report_Chef.get_id(Show_Detailed_Recipe.r_id, Show_Detailed_Recipe.u_id);
            report_Chef.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show_Nutrition show_Nutrition = new Show_Nutrition();
            show_Nutrition.get_rid(Show_Detailed_Recipe.r_id);
            show_Nutrition.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_Ingredients view_Ingredients = new View_Ingredients();
            view_Ingredients.get_rid(Show_Detailed_Recipe.r_id);
            view_Ingredients.Show();
        }
    }
}
