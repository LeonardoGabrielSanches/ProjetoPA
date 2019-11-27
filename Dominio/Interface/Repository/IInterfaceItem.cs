using System;
using System.Collections.Generic;
using System.Text;
using VendasAPI.Domínio.Entidades;

namespace Dominio.Interface.Repository
{
    public interface IInterfaceItem
    { 
        Item GetItem(string descricao);

        ValidateResult PostItem(Item item);

        ValidateResult PutItem(Item item);

        ValidateResult RemoveItem(int id);

        List<Item> GetAllItem();
    }
}
