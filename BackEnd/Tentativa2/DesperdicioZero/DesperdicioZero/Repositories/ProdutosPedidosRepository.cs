using DesperdicioZero.Interfaces;
using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Repositories
{
    public class ProdutosPedidosRepository : IProdutosPedidosRepository
    {
        DesperdicioZeroContext ctx = new DesperdicioZeroContext();

        public void Apagar(int IdprodutoPedido)
        {
            ProdutoPedido produtoPedidoProcurado = ctx.ProdutoPedido.Find(IdprodutoPedido);
            ctx.ProdutoPedido.Remove(produtoPedidoProcurado);
            ctx.SaveChanges();
        }

        public void Cadastrar(ProdutoPedido produtoPedido)
        {
                ctx.ProdutoPedido.Add(produtoPedido);
                ctx.SaveChanges();

           
        }

        public ProdutoPedido Editar(ProdutoPedido produtoPedido)
        {
            ProdutoPedido produtoPedidoExiste = ctx.ProdutoPedido.Find(produtoPedido.IdprodutoPedido);

            if (produtoPedidoExiste != null)
            {

                produtoPedidoExiste.IdPedido = produtoPedido.IdPedido;
                produtoPedidoExiste.IdProduto = produtoPedido.IdProduto;
                produtoPedidoExiste.Quantidade = produtoPedido.Quantidade;

                ctx.ProdutoPedido.Update(produtoPedidoExiste);
                ctx.SaveChanges();

                return produtoPedidoExiste;
            }

            return null;
        }

        public List<ProdutoPedido> Listar()
        {
            return (ctx.ProdutoPedido.ToList());
        }
    }
}
