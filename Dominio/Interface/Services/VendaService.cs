using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using VendasAPI.Domínio.Entidades;

namespace Dominio.Interface.Services
{
    public class VendaService : Interface.Repository.IInterfaceVenda
    {
        private readonly Repository.IInterfaceVenda repository;

        public VendaService(Interface.Repository.IInterfaceVenda _repository)
        {
            repository = _repository;
        }

        public PedidoDeVenda GetPedido(int id)
        {
            var pedido = repository.GetPedido(id);
            return pedido;
        }

        public ValidateResult PostPedido(PedidoDeVenda pedido)
        {
            var validateResult = repository.PostPedido(pedido);
            return validateResult;
        }

        public ValidateResult PutPedido(PedidoDeVenda pedido)
        {
            var validateResult = repository.PutPedido(pedido);
            return validateResult;
        }
    }
}