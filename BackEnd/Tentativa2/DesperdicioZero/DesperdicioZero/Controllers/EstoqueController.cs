using DesperdicioZero.Interfaces;
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

        //        //Adicionar um usuário
        //        [HttpPost]
        //        public IActionResult Post(Usuario usuario)
        //        {
        //            try
        //            {
        //                UsuarioRepository.Cadastrar(usuario);
        //                return Ok();
        //            }
        //            catch (System.Exception ex)
        //            {
        //                return BadRequest();
        //            }
        //        }

        //        //Modificar um Usuario
        //        [HttpPut()]
        //        public IActionResult Put(Usuario usuario)
        //        {

        //            UsuarioRepository.Editar(usuario);
        //            if (UsuarioRepository.Editar(usuario) == null) { return NotFound(); }
        //            return Ok();

        //        }

        //        //Apagar um Usuario
        //        [HttpDelete()]
        //        public IActionResult Delete(Usuario usuario)
        //        {
        //            int id = new int();
        //            id = usuario.Idusuario;

        //            try
        //            {
        //                UsuarioRepository.Apagar(id);
        //                return Ok();
        //            }
        //            catch (Exception ex)
        //            {
        //                return NotFound();
        //            }

        //        }

        //    }
        //}
    }
}
