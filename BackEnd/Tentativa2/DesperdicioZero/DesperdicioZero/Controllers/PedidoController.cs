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
    [Route("api/pedidos")]
    [ApiController]
    public class PedidoController : Controller
    {
        private IPedidosRepository PedidosRepository { get; set; }

        public PedidoController()
        {
            PedidosRepository = new PedidosRepository();
        }

        //Listar os Pedidos

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(PedidosRepository.Listar());

            }

            catch
            {
                return BadRequest();
            }
        }

        //Adicionar um Pedido
        [HttpPost]
        public IActionResult Post(Pedido pedido)
        {
            try
            {
                PedidosRepository.Cadastrar(pedido);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }

        //Modificar um ProdutoPedido
        [HttpPut()]
        public IActionResult Put(Pedido IdPedido)
        {

            PedidosRepository.Editar(IdPedido);
            if (PedidosRepository.Editar(IdPedido) == null) { return NotFound(); }
            return Ok();

        }

        //Apagar um ProdutoPedido
        [HttpDelete()]
        public IActionResult Delete(Pedido pedido)
        {
            int id = new int();
            id = pedido.Idpedido;

            try
            {
                PedidosRepository.Apagar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }



    }
}
