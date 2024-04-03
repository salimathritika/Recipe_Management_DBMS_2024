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
            User_Login frm = new User_Login();
            frm.Show();
        }
    }
}
