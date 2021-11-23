using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Interfaces
{
    interface ITiposRepository
    {
        List<Tipo> Listar();
        void Cadastrar(Tipo tipo);
        Tipo Editar(Tipo tipo);
        void Apagar(int id);

    }
}
