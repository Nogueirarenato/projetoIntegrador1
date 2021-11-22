    using System;
using System.Collections.Generic;

namespace DesperdicioZero.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            Estoque = new HashSet<Estoque>();
            Pedido = new HashSet<Pedido>();
        }

        public int Idusuario { get; set; }
        public int? IdTipo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }

        public virtual Tipo IdTipoNavigation { get; set; }
        public virtual ICollection<Estoque> Estoque { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
