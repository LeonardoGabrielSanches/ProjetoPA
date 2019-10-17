using Dominio.Entidades;
using Dominio.Interface.Repository;
using System;
using VendasAPI.Domínio.Entidades;
using VendasAPI.Infra.Context;

namespace InfraSql.Repositório
{
    public class VendaRepositorio : BaseValidate, IInterfaceVenda
    {
        private VendaContext context = new VendaContext();

        public PedidoDeVenda GetPedido(int id)
        {
            PedidoDeVenda pedido = EncontraPedido(id);
            if (pedido == null)
                return null;

            return pedido;
        }

        public ValidateResult PostPedido(PedidoDeVenda pedido)
        {
            ValidateResult validateResult = new ValidateResult();
            //Realizar Validaçoes com validateResult

            context.Pedido.Add(pedido);

            context.SaveChanges();

            return validateResult;
        }

        public ValidateResult PutPedido(PedidoDeVenda pedido)
        {
            ValidateResult validateResult = new ValidateResult();
            if(EncontraPedido(pedido.VendaId) == null)
            {
                validateResult.MensagemErro = $"Pedido não encontrado";
                return validateResult;
            }

            context.Pedido.Attach(pedido).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.Pedido.Update(pedido);

            context.SaveChanges();

            return validateResult;
        }

        private PedidoDeVenda EncontraPedido(int id)
             => context.Pedido.Find(id);
    }
}
