using System;
using System.Collections.Generic;
using System.Text;
using VendasAPI.Domínio.Entidades;

namespace Dominio.Interface.Services
{
    class ClienteService : Interface.Repository.IInterfaceGeral
    {
        private Repository.IInterfaceGeral repository;

        public ClienteService(Interface.Repository.IInterfaceGeral _repository)
        {
            repository = _repository;
        }

        public Cliente GetCliente(string procura)
        {
            var cliente = repository.GetCliente(procura);
            return cliente;
        }     

        public ValidateResult PostCliente(string documento)
        {
            var validateResult = repository.PostCliente(documento);
            return validateResult;
        }

        public ValidateResult PutCliente(Cliente cliente)
        {
            var validateResult = repository.PutCliente(cliente);
            return validateResult;
        }

        public ValidateResult RemoveCliente(string documento)
        {
            var validateResult = repository.RemoveCliente(documento);
            return validateResult; ;
        }
    }
}
