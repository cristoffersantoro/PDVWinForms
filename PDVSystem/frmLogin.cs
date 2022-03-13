namespace PDVSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new FrmPrincipal().Show();
            this.Hide();
        }
    }
}