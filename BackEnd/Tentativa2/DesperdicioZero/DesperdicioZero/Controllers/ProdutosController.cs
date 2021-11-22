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
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : Controller
    {

        private IProdutosRepository ProdutoRepository { get; set; }

        public ProdutosController()
        {
            ProdutoRepository = new ProdutosRepository();
        }

        //Listar os Produtos

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(ProdutoRepository.Listar());

            }

            catch
            {
                return BadRequest();
            }
        }
        //Adicionar um usuário
        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            try
            {
                ProdutoRepository.Cadastrar(produto);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }


        //Modificar um Produto
        [HttpPut()]
        public IActionResult Put(Produto produto)
        {

            ProdutoRepository.Editar(produto);
            if (ProdutoRepository.Editar(produto) == null) { return NotFound(); }
            return Ok();

        }

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
