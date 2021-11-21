using System;
using System.Collections.Generic;

namespace DesperdicioZero.Model
{
    public partial class Estoque
    {
        public Estoque()
        {
            Produto = new HashSet<Produto>();
        }

        public int Idestoque { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
