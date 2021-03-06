using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Interfaces
{
    interface IEstoquesRepository
    {
        List<Estoque> Listar();
        void Cadastrar(Estoque estoque);
        Estoque Editar(Estoque estoque);
        void Apagar(int id);
    }
}
