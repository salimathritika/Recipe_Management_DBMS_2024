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
using System.Xml.Linq;

namespace Recipe_Management_Project
{
    public partial class Show_Nutrition : Form
    {
        SqlConnection conn;
        static string rid;
        public Show_Nutrition()
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
                MessageBox.Show("Connection established");
            }
            catch (Exception ex) { }
        }
        public void get_rid(string rid)
        {
            Show_Nutrition.rid = rid;
        }
        private void Show_Nutrition_Load(object sender, EventArgs e)
        {
            connectDB();
            string carb, fat, pro, sod , chol, sug, glu, caf;

            string q3 = "select carbs,fat,protein,sodium,cholesterol,sugar_content,caffeine,gluten_content from nutritional_value where recipe_id =" + Show_Nutrition.rid + ";";
            SqlCommand cmd3 = new SqlCommand(q3, conn);
            try
            {
                SqlDataReader dr = cmd3.ExecuteReader();
                dr.Read();
                carb= dr.GetInt32(0).ToString();
                fat= dr.GetInt32(1).ToString();
                pro = dr.GetInt32(2).ToString();
                sod = dr.GetInt32(3).ToString();
                chol = dr.GetInt32(4).ToString();
                sug = dr.GetInt32(5).ToString();
                caf = dr.GetInt32(6).ToString();
                glu = dr.GetInt32(7).ToString();
                cmd3.Dispose(); 
                dr.Close();
                
                richTextBox1.Text = "Nutritional values:\nCarbohydrates:" + carb + "\nFat:" + fat + "\nProtein:" + pro + "\nSodium:" + sod + "\nCholestrol:" + chol + "\nSugar:" + sug + "\nCaffeine:" + caf + "\nGluten content:" + glu+"\n";
            }
            catch (Exception ex) { }
            conn.Close();
        }
    }
}
