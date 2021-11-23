using DesperdicioZero.Interfaces;
using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Repositories
{
    public class PedidosRepository : IPedidosRepository
    {
        DesperdicioZeroContext ctx = new DesperdicioZeroContext();

        public void Apagar(int Idpedido)
        {
            Pedido pedidoProcurado = ctx.Pedido.Find(Idpedido);
            ctx.Pedido.Remove(pedidoProcurado);
            ctx.SaveChanges();
        }
        public List<Pedido> Listar()
        {
            return (ctx.Pedido.ToList());
        }

        public void Cadastrar(Pedido pedido)
        {
            ctx.Pedido.Add(pedido);
            ctx.SaveChanges();


        }

        public Pedido Editar(Pedido pedido)
        {
            Pedido pedidoExiste = ctx.Pedido.Find(pedido.Idpedido);

            if (pedidoExiste != null)
            {

                pedidoExiste.Valor = pedido.Valor;

                pedidoExiste.IdUsuario = pedido.IdUsuario;
                ctx.Pedido.Update(pedidoExiste);
                ctx.SaveChanges();

                return pedidoExiste;
            }

            return null;
        }

    }
}
