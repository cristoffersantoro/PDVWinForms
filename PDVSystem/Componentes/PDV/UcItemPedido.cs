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

namespace PDVSystem.Componentes.PDV
{
    public partial class UcItemPedido : UserControl
    {
        public UcItemPedido()
        {
            InitializeComponent();
        }

        public void InserirAtributos(string? nomeProduto, int quantidade)
        {
            lblNomeProduto.Text = nomeProduto;
            numQtdeItems.Value = quantidade;
        }

        public void IncrementarQuantidade()
        {
            numQtdeItems.Value += 1;
        }

        public void DecrementarQuantidade()
        {
            numQtdeItems.Value -= 1;
        }

        private void numQtdeItems_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UcItemPedido_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
