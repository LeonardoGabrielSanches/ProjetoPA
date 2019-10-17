using System;
using System.Collections.Generic;
using System.Text;
using VendasAPI.Domínio.Entidades;

namespace Dominio.Interface.Services
{
    public class ItemService
    {
        private Repository.IInterfaceItem repository;

        public ItemService(Interface.Repository.IInterfaceItem _repository)
        {
            repository = _repository;
        }

        public Item GetItem(int id)
        {
            var item = repository.GetItem(id);
            return item;
        }
        public ValidateResult PostItem(Item item)
        {
            var validateResult = repository.PostItem(item);
            return validateResult;
        }

        public ValidateResult PutItem(Item item)
        {
            var validateResult = repository.PutItem(item);
            return validateResult;
        }

        public ValidateResult RemoveItem(int id)
        {
            var validateResult = repository.RemoveItem(id);
            return validateResult; ;
        }
    }
}
