using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVSystem.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }
        public string? Imagem { get; set; }
        public bool Apagado { get; set; }
        public string? novaImagem { get; set; }

        public static readonly string CAMINHO_PADRAO_IMAGEM = "Recursos\\product_default.png";
    }
}
