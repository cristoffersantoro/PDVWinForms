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
    public partial class ucItemProduto : UserControl
    {
        public event EventHandler<Produto>? BotaoAdicionarProdutoClick;

        private readonly Produto produto;
        public ucItemProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
        }

        private void ucItemProduto_Load(object sender, EventArgs e)
        {
            lblNomeProduto.Text = produto.Nome;
            lblPrecoProduto.Text = $"R$ {produto.Preco}";
            ptbImagemProduto.ImageLocation = produto.Imagem;
        }

        private void BotaoAdicionarProduto_Click(Object sender, EventArgs e)
        {
            if(BotaoAdicionarProdutoClick != null) BotaoAdicionarProdutoClick(sender, produto);
        }
    }
}
