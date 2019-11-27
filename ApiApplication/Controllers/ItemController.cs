using Dominio.Interface.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IInterfaceItem item;

        public ItemController(IInterfaceItem iItem)
        {
            item = iItem;
        }

        // GET: api/ControleVenda/5
        [HttpGet]
        public IActionResult GetByNumeroEstoque(string descricao)
        {
            var itemBanco = item.GetItem(descricao);
            if (itemBanco == null)
                return NoContent();
            else
                return Ok(itemBanco);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = item.GetAllItem();
            if (lista == null)
                return NoContent();
            else
                return Ok(lista);
        }

        // POST: api/ControleVenda
        [HttpPost]
        public IActionResult Post([FromForm]Item itemAPI)
        {
            var validateResult = item.PostItem(itemAPI);

            if (!validateResult.Isvalid)
                return BadRequest(validateResult.MensagemErro);

            var itemBanco = item.GetItem(itemAPI.Descricao);
            return Ok(itemBanco.CodigoEstoque.ToString());
        }

        // PUT: api/ControleVenda/5
        [HttpPut("{id}")]
        public void Put(int id, [FromHeader] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{documento}")]
        public IActionResult Delete(int numeroDocumento)
        {
            try
            {
                var validateResult = item.RemoveItem(numeroDocumento);

                if (!validateResult.Isvalid)
                    return BadRequest(validateResult.MensagemErro);

                return NoContent();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
