using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVSystem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is frmLogin);

            if (formToShow != null)
            {
                formToShow.Show();
            }
        }
    }
}
