using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Interfaces
{
    interface IProdutosRepository
    {
        List<Produto> Listar();
        void Cadastrar(Produto produto);
        Produto Editar(Produto produto);
    }
}
