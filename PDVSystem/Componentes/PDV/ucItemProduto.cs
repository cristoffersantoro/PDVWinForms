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
    public partial class UcItemProduto : UserControl
    {
        public event EventHandler<Produto>? BotaoAdicionarProdutoClick;

        private readonly Produto produto;
        public UcItemProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
        }

        private void ucItemProduto_Load(object sender, EventArgs e)
        {
            lblNomeProduto.Text = produto.Nome;
            lblPrecoProduto.Text = $"R$ {produto.Preco}";
            btnIndisponivel.Visible = false;
            ptbImagemProduto.ImageLocation = produto.Imagem;
            this.BackColor = SystemColors.Control;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (BotaoAdicionarProdutoClick != null) BotaoAdicionarProdutoClick(sender, produto);
        }
    }
}
