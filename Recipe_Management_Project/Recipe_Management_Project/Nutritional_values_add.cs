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
    public partial class Nutritional_values_add : Form
    {
        SqlConnection conn;
        static string rid,carb="0",fat="0",pro="0",sod="0",chol="0",sug="0",glu="0",caf="0";
        public Nutritional_values_add()
        {
            InitializeComponent();
        }

        public void get_rid(string id)
        {
            Nutritional_values_add.rid = id;
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

        private void Nutritional_values_add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nutritional_values_add.carb += textBox1.Text;
            Nutritional_values_add.fat += textBox2.Text;
            Nutritional_values_add.pro += textBox3.Text;
            Nutritional_values_add.sod += textBox4.Text;
            Nutritional_values_add.chol += textBox5.Text;
            Nutritional_values_add.sug += textBox6.Text;
            Nutritional_values_add.caf += textBox7.Text;
            Nutritional_values_add.glu += textBox8.Text;

            connectDB();
            string q = "INSERT INTO nutritional_value VALUES ("+ Nutritional_values_add.rid+"," + Nutritional_values_add.carb + ", " + Nutritional_values_add.fat + "," + Nutritional_values_add.pro + "," + Nutritional_values_add.sod + "," + Nutritional_values_add.chol + ", " + Nutritional_values_add.sug + "," + Nutritional_values_add.caf + "," + Nutritional_values_add.glu + ");";
            SqlCommand cmd= new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Nutritional values are inserted");
            cmd.Dispose();
            conn.Close();
        }
    }
}
