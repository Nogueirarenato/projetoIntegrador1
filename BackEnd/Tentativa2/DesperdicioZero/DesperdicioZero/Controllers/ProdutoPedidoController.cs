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
    [Route("api/produtospedidos")]
    [ApiController]
    public class ProdutoPedidoController : Controller
    {
        private IProdutosPedidosRepository ProdutosPedidosRepository { get; set; }

        public ProdutoPedidoController()
        {
            ProdutosPedidosRepository = new ProdutosPedidosRepository();
        }

        //Listar os Produtos Pedidos

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(ProdutosPedidosRepository.Listar());

            }

            catch
            {
                return BadRequest();
            }
        }


        //Adicionar um ProdutoPedido
        [HttpPost]
        public IActionResult Post(ProdutoPedido produtoPedido)
        {
            try
            {
                ProdutosPedidosRepository.Cadastrar(produtoPedido);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }


        //Modificar um ProdutoPedido
        [HttpPut()]
        public IActionResult Put(ProdutoPedido produtoPedido)
        {

            ProdutosPedidosRepository.Editar(produtoPedido);
            if (ProdutosPedidosRepository.Editar(produtoPedido) == null) { return NotFound(); }
            return Ok();

        }

        //Apagar um ProdutoPedido
        [HttpDelete()]
        public IActionResult Delete(ProdutoPedido produtoPedido)
        {
            int id = new int();
            id = produtoPedido.IdprodutoPedido;

            try
            {
                ProdutosPedidosRepository.Apagar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

    }
}
