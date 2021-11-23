using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Interfaces
{
    interface IPedidosRepository
    {
        List<Pedido> Listar();
        void Cadastrar(Pedido pedido);
        Pedido Editar(Pedido pedido);
        void Apagar(int id);
    }
}
