using DesperdicioZero.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesperdicioZero.Model;

namespace DesperdicioZero.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        DesperdicioZeroContext ctx = new DesperdicioZeroContext();

        public void Cadastrar(Usuario usuario)
        {
            ctx.Usuario.Add(usuario);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
            {
                return (ctx.Usuario.ToList());
            
            }
    }
}
