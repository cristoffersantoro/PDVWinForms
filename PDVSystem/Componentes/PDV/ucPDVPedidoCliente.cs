using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVSystem.Componentes.PDV
{
    public partial class UcPdvPedidoCliente : UserControl
    {
        public UcPdvPedidoCliente()
        {
            InitializeComponent();
            this.panel1.BackColor = SystemColors.ButtonFace;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessarPedido_Click(object sender, EventArgs e)
        {
            var frmProcessarPedido = new frmProcessarPedido();
            frmProcessarPedido.ShowDialog();
        }
    }
}
