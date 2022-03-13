using PDVSystem.Componentes.PDV;
using PDVSystem.Model;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pnlPrincipal.Width = this.Width;
            pnlPrincipal.Height = this.Height;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is FrmLogin);

            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        public void AdicionarItemProduto_Click(Object? sender, Produto produto)
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            FlowLayoutPanel pedidoCliente = (FlowLayoutPanel)ucPdvPedidoCliente.Controls.Find("flwPedidoCliente", true).FirstOrDefault();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

            if (pedidoCliente is null) return;

            pedidoCliente.SuspendLayout();

            var itemPedido = (UcItemPedido)pedidoCliente.Controls.Find($"UcItemPedido_{produto.Id}", true).FirstOrDefault();

            if(itemPedido is null)
            {
                itemPedido = new UcItemPedido();
                itemPedido.Name = $"UcItemPedido_{produto.Id}";
                itemPedido.InserirAtributos(produto.Nome, 1);
                pedidoCliente.Controls.Add(itemPedido);
            }
            else { 
                itemPedido.IncrementarQuantidade();
            }
                        
            pedidoCliente.ResumeLayout();
        }
    }
}
