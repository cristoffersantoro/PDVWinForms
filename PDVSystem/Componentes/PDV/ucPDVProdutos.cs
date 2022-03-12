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
    public partial class ucPDVProdutos : UserControl
    {
        
        public ucPDVProdutos()
        {
            InitializeComponent();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            fplItemsProduto.SuspendLayout();
            fplItemsProduto.Controls.Clear();

            var produto1 = new ucItemProduto(
                    new Produto()
                    {
                        Id = 1,
                        Nome = "Hambúrguer",
                        Preco = 27.90M,
                        Imagem = Application.StartupPath + "Recursos\\burger.png"
                    }
                );

            

            produto1.BotaoAdicionarProdutoClick += ItemProduto_Click;
            

            fplItemsProduto.Controls.Add(produto1);

            var produto2 = new ucItemProduto(
                    new Produto()
                    {
                        Id = 1,
                        Nome = "Combo",
                        Preco = 39.90M,
                        Imagem = Application.StartupPath + "Recursos\\burger_soda_black.png"
                    }
                );

            produto2.BotaoAdicionarProdutoClick += ItemProduto_Click;

            fplItemsProduto.Controls.Add(produto2);

            fplItemsProduto.ResumeLayout();
        }

        public void ItemProduto_Click(Object? sender, Produto e)
        {

        }

        private void ucPDVProdutos_Load(object sender, EventArgs e)
        {
            this.btnRefeicao.Image = (Image)(new Bitmap(Image.FromFile(Application.StartupPath + "Recursos\\soup.png"), new Size(20, 20)));
            this.btnBebidas.Image = (Image)(new Bitmap(Image.FromFile(Application.StartupPath + "Recursos\\glass.png"), new Size(20, 20)));
            this.btnLanches.Image = (Image)(new Bitmap(Image.FromFile(Application.StartupPath + "Recursos\\burger.png"), new Size(20, 20)));
            this.btnSobremesas.Image = (Image)(new Bitmap(Image.FromFile(Application.StartupPath + "Recursos\\icecream.png"), new Size(20, 20)));
            this.btnCombos.Image = (Image)(new Bitmap(Image.FromFile(Application.StartupPath + "Recursos\\burger_soda_black.png"), new Size(20, 20)));
        }
    }
}
