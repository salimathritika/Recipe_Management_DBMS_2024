namespace Recipe_Management_Project
{
    public partial class Mode_Select : Form
    {
        public Mode_Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login frm = new User_Login();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_Login chef_Login = new Chef_Login();
            chef_Login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login admin_Login = new Admin_Login();    
            admin_Login.Show();
        }
    }
}
