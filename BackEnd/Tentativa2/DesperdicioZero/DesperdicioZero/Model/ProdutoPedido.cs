using System;
using System.Collections.Generic;

namespace DesperdicioZero.Model
{
    public partial class ProdutoPedido
    {
        public int IdprodutoPedido { get; set; }
        public int? IdPedido { get; set; }
        public int? IdProduto { get; set; }
        public int? Quantidade { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
