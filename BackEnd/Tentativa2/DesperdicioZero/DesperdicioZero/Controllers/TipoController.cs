using DesperdicioZero.Interfaces;
using DesperdicioZero.Model;
using DesperdicioZero.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Controllers
{
    [Produces("application/json")]
    [Route("api/tipos")]
    [ApiController]
    public class TipoController : Controller
    {
        private ITiposRepository TiposRepository { get; set; }

        public TipoController()
        {
            TiposRepository = new TiposRepository();
        }

        //Listar os Tipos

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(TiposRepository.Listar());

            }

            catch
            {
                return BadRequest();
            }
        }

        //Adicionar um Tipo
        [HttpPost]
        public IActionResult Post(Tipo tipo)
        {
            try
            {
                TiposRepository.Cadastrar(tipo);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }


        //Modificar um Tipo
        [HttpPut()]
        public IActionResult Put(Tipo IdTipo)
        {

            TiposRepository.Editar(IdTipo);
            if (TiposRepository.Editar(IdTipo) == null) { return NotFound(); }
            return Ok();

        }

        //Apagar um Tipo
        [HttpDelete()]
        public IActionResult Delete(Tipo tipo)
        {
            int id = new int();
            id = tipo.Idtipo;

            try
            {
                TiposRepository.Apagar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }


    }
}
