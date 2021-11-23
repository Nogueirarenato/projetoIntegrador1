using DesperdicioZero.Interfaces;
using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Repositories
{
    public class TiposRepository : ITiposRepository
    {
        DesperdicioZeroContext ctx = new DesperdicioZeroContext();

        public void Apagar(int id)
        {
            Tipo tipoProcurado = ctx.Tipo.Find(id);
            ctx.Tipo.Remove(tipoProcurado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Tipo tipo)
        {
            ctx.Tipo.Add(tipo);
            ctx.SaveChanges();
        }

        public Tipo Editar(Tipo tipo)
        {
            Tipo tipoExiste = ctx.Tipo.Find(tipo.Idtipo);

            if (tipoExiste != null)
            {

                tipoExiste.Tipo1 = tipo.Tipo1;

                
                ctx.Tipo.Update(tipoExiste);
                ctx.SaveChanges();

                return tipoExiste;
            }

            return null;
        }

        public List<Tipo> Listar()
        {
            return (ctx.Tipo.ToList());
        }
    }

       
            
               
            

        
    }

