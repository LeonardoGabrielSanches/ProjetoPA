using Dominio.Entidades;
using VendasAPI.Domínio.Entidades;

namespace Dominio.Interface.Repository
{
    public interface IInterfaceVenda
    {
        PedidoDeVenda GetPedido(int id);

        ValidateResult PostPedido(PedidoDeVenda pedido);

        ValidateResult PutPedido(PedidoDeVenda pedido);
    }
}
