using System;
using System.Collections.Generic;

namespace DesperdicioZero.Model
{
    public partial class Tipo
    {
        public Tipo()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int Idtipo { get; set; }
        public string Tipo1 { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
