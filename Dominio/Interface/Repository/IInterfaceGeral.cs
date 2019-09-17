using VendasAPI.Domínio.Entidades;

namespace Dominio.Interface.Repository
{
    public interface IInterfaceGeral
    {
        Cliente GetCliente(string procura);

        ValidateResult PostCliente(string documento);

        ValidateResult PutCliente(Cliente cliente);

        ValidateResult RemoveCliente(string documento);
    }
}
