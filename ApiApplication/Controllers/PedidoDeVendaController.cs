using Dominio.Entidades;
using Dominio.Interface.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoDeVendaController : ControllerBase
    {
        private readonly IInterfaceVenda pedido;

        public PedidoDeVendaController(IInterfaceVenda geral)
        {
            pedido = geral;
        }

        // GET: api/ControleVenda/5
        [HttpGet]
        public IActionResult GetByDocument(int id)
        {
            var pedidoDeVenda =pedido.GetPedido(id);
            if (pedidoDeVenda != null)
                return Ok(pedidoDeVenda);
            else
                return BadRequest("Pedido não encontrado no banco de dados");
        }

        // POST: api/ControleVenda
        [HttpPost]
        public IActionResult Post([FromHeader] PedidoDeVenda pedidoDeVenda)
        {
            var validateResult = pedido.PostPedido(pedidoDeVenda);          
                if (!validateResult.Isvalid)
                return BadRequest(validateResult.MensagemErro);

            return Ok("Pedido cadastrado com sucesso");
        }

        // PUT: api/ControleVenda/5
        [HttpPut("{id}")]
        public IActionResult Put([FromHeader] PedidoDeVenda pedidoDeVenda)
        {
            ValidateResult validateResult = pedido.PutPedido(pedidoDeVenda);
            if (!validateResult.Isvalid)
                return BadRequest($"{validateResult.MensagemErro}");
            else
                return Ok("Pedido atualizado com sucesso");

        }
    }
}
