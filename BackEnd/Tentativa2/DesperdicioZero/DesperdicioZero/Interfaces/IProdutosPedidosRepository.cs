using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Interfaces
{
    interface IProdutosPedidosRepository
    {
        List<ProdutoPedido> Listar();
        void Cadastrar(ProdutoPedido produtoPedido);
        ProdutoPedido Editar(ProdutoPedido produtoPedido);

        void Apagar(int id);
    }
}
