using System;
using System.Collections.Generic;

namespace DesperdicioZero.Model
{
    public partial class Produto
    {
        public Produto()
        {
            ProdutoPedido = new HashSet<ProdutoPedido>();
        }

        public int Idproduto { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeValidade { get; set; }
        public int Prazo { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? ValorVenda { get; set; }
        public decimal? Desconto { get; set; }
        public int? IdEstoque { get; set; }
        public int? Quantidade { get; set; }
        public string Descricao { get; set; }

        public virtual Estoque IdEstoqueNavigation { get; set; }
        public virtual ICollection<ProdutoPedido> ProdutoPedido { get; set; }
    }
}
