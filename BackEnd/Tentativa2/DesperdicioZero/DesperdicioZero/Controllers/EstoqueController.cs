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
    [Route("api/estoques")]
    [ApiController]
    public class EstoquesController : Controller
    {

        private IEstoquesRepository EstoqueRepository { get; set; }

        public EstoquesController()
        {
            EstoqueRepository = new EstoquesRepository();
        }

        //Listar os Estoques

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(EstoqueRepository.Listar());

            }

            catch
            {
                return BadRequest();
            }
        }

        //Adicionar um estoque
        [HttpPost]
        public IActionResult Post(Estoque estoque)
        {
            try
            {
                EstoqueRepository.Cadastrar(estoque);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }

        //Modificar um estoque
        [HttpPut()]
        public IActionResult Put(Estoque estoque)
        {

            EstoqueRepository.Editar(estoque);
            if (EstoqueRepository.Editar(estoque) == null) { return NotFound(); }
            return Ok();

        }

        //Apagar um estoque
        [HttpDelete()]
        public IActionResult Delete(Estoque estoque)
        {
            int id = new int();
            id = estoque.Idestoque;

            try
            {
                EstoqueRepository.Apagar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }


    }
}
