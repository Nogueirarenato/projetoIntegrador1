using DesperdicioZero.Interfaces;
using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Repositories
{
    public class ProdutosRepository : IProdutosRepository
    {
        DesperdicioZeroContext ctx = new DesperdicioZeroContext();

        public void Cadastrar(Produto produto)
        {
            ctx.Produto.Add(produto);
            ctx.SaveChanges();
        }

        public Produto Editar(Produto produto)
        {
            Produto produtoExiste = ctx.Produto.Find(produto.Idproduto);

            if (produtoExiste != null)
            {

                produtoExiste.DataDeValidade = produto.DataDeValidade;
                produtoExiste.Desconto = produto.Desconto;
                produtoExiste.Descricao = produto.Descricao;
                produtoExiste.Nome = produto.Nome;
                produtoExiste.Prazo = produto.Prazo;
                produtoExiste.Quantidade = produto.Quantidade;
                produtoExiste.ValorCompra = produto.ValorCompra;
                produtoExiste.ValorVenda = produto.ValorVenda;





                ctx.Produto.Update(produtoExiste);
                ctx.SaveChanges();

                return produtoExiste;
            }

            return null;
        
    }

        public List<Produto> Listar()
        {
            return (ctx.Produto.ToList());
        }
    }
}
