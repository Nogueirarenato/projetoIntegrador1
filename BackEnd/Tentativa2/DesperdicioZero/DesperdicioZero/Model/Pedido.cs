using System;
using System.Collections.Generic;

namespace DesperdicioZero.Model
{
    public partial class Pedido
    {
        public Pedido()
        {
            ProdutoPedido = new HashSet<ProdutoPedido>();
        }

        public int Idpedido { get; set; }
        public decimal? Valor { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ProdutoPedido> ProdutoPedido { get; set; }
    }
}
