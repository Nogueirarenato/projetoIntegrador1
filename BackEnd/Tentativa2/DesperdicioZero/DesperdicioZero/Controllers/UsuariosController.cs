using DesperdicioZero.Interfaces;
using DesperdicioZero.Repositories;
using Microsoft.AspNetCore.Mvc;
using DesperdicioZero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesperdicioZero.Controllers
{
    [Produces("application/json")]
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuariosRepository UsuarioRepository { get; set; }

        public UsuariosController()
        {
            UsuarioRepository = new UsuariosRepository();
        }

        //Listar os Administradores

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(UsuarioRepository.Listar());

            }

            catch
            {
                return BadRequest();
            }
        }

        //Adicionar um usuário
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                UsuarioRepository.Cadastrar(usuario);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }

        //Modificar um Usuario
        [HttpPut()]
        public IActionResult Put(Usuario usuario)
        {

            UsuarioRepository.Editar(usuario);
            if (UsuarioRepository.Editar(usuario) == null) { return NotFound(); }
            return Ok();

        }

        //Apagar um Usuario
        [HttpDelete()]
        public IActionResult Delete(Usuario usuario)
        {
            int id = new int();
            id = usuario.Idusuario;

            try
            {
                UsuarioRepository.Apagar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

    }
}
