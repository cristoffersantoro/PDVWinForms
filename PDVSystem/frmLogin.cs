namespace PDVSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new frmPrincipal().Show();
            this.Hide();
        }
    }
}