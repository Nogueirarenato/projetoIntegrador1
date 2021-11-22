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

        public void Apagar(int idusuario)
        {
            Usuario usuarioProcurado = ctx.Usuario.Find(idusuario);
            ctx.Usuario.Remove(usuarioProcurado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Usuario usuario)
        {
            ctx.Usuario.Add(usuario);
            ctx.SaveChanges();
        }

        public Usuario Editar(Usuario usuario)
        {
            Usuario usuarioExiste = ctx.Usuario.Find(usuario.Idusuario);

            if (usuarioExiste != null)
            {

                usuarioExiste.Email = usuario.Email;
                usuarioExiste.Senha = usuario.Senha;
                usuarioExiste.Endereco = usuario.Endereco;
                usuarioExiste.IdTipo = usuario.IdTipo;
                usuarioExiste.Telefone = usuario.Telefone;
                usuarioExiste.Documento = usuario.Documento;
                


                ctx.Usuario.Update(usuarioExiste);
                ctx.SaveChanges();

                return usuarioExiste;
            }

            return null;
        }
        public List<Usuario> Listar()
            {
                return (ctx.Usuario.ToList());
            
            }
    }
}
