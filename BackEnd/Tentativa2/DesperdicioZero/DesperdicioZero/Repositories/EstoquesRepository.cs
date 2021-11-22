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
        public List<Estoque> Listar()
        {
            return (ctx.Estoque.ToList());
        }
    }
}
