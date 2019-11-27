﻿using Dominio.Interface.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IInterfaceGeral cliente;

        public ClienteController(IInterfaceGeral geral)
        {
            cliente = geral;
        }

        // GET: api/ControleVenda/5
        [HttpGet]
        public IActionResult GetByDocument(string documento)
        {
            var clienteConsulta = cliente.GetCliente(documento);
            if (cliente == null)
                return NoContent();
            else
                return Ok(clienteConsulta);
        }

        // POST: api/ControleVenda
        [HttpPost]
        public IActionResult Post(string documento)
        {
            var validateResult = cliente.PostCliente(documento);
            if (!validateResult.Isvalid)
                return BadRequest(validateResult.MensagemErro);

            var clienteRetorno = cliente.GetCliente(documento);
            return Ok($"{clienteRetorno.Nome.ToString()},{clienteRetorno.ClienteID.ToString()}");
        }

        // PUT: api/ControleVenda/5
        [HttpPut("{id}")]
        public void Put(int id, [FromHeader] Cliente cliente)
        {
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{documento}")]
        public IActionResult Delete(string documento)
        {
            try
            {
                var validateResult = cliente.RemoveCliente(documento);
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
