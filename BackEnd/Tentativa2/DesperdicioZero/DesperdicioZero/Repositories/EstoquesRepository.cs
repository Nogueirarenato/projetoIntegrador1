using DesperdicioZero.Interfaces;
using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Repositories
{
    public class EstoquesRepository : IEstoquesRepository
    {
        DesperdicioZeroContext ctx = new DesperdicioZeroContext();

        public void Apagar(int Idestoque)
        {
            Estoque estoqueProcurado = ctx.Estoque.Find(Idestoque);
            ctx.Estoque.Remove(estoqueProcurado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Estoque estoque)
        {
              ctx.Estoque.Add(estoque);
                ctx.SaveChanges();
            
        }

        public Estoque Editar(Estoque estoque)
        {
            Estoque estoqueExiste = ctx.Estoque.Find(estoque.Idestoque);

            if (estoqueExiste != null)
            {

                estoqueExiste.IdUsuario = estoque.IdUsuario;
                



                ctx.Estoque.Update(estoqueExiste);
                ctx.SaveChanges();

                return estoqueExiste;
            }

            return null;
        }

        public List<Estoque> Listar()
        {
            return (ctx.Estoque.ToList());
        }
    }
}
