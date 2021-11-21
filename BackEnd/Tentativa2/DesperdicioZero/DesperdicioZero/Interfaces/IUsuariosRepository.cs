using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Interfaces
{
    
    interface IUsuariosRepository
    {
        List<Usuario> Listar();
        void Cadastrar(Usuario usuario);
    }
}
