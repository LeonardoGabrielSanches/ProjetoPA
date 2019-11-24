using System;
using System.Linq;
using Dominio.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Domínio.Entidades;
using VendasAPI.Infra.Context;

namespace InfraSql.Repositório
{
    public class ItemRepositorio : BaseValidate, IInterfaceItem
    {
        private VendaContext context = new VendaContext();

        public Item GetItem(int id)
        {
            try
            {
                var item = GetItemBanco(id);
                return item;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public ValidateResult PostItem(Item item)
        {
            ValidateResult validateResult = new ValidateResult();
            try
            {
                //Realizar validaçoes do item

                var itemBanco = GetItemBanco(item.CodigoEstoque);

                if(itemBanco != null)
                {
                    validateResult.MensagemErro = $"Item já existente no banco";
                    return validateResult;
                }

                //FAZER A CHAMADA DA FUNÇAO QUE SETA A MARGEM

                context.Item.Add(item);

                context.SaveChanges();

                return validateResult;
            }
            catch ( Exception ex)
            {
                validateResult.MensagemErro = $"{ex.Message}";
                return validateResult;
            }
        }

        public ValidateResult PutItem(Item item)
        {
            ValidateResult validateResult = new ValidateResult();
            try
            {
                var itemBanco = GetItemBanco(item.CodigoEstoque);
                if (itemBanco == null)
                {
                    validateResult.MensagemErro = $"Item não cadastrado no banco";
                    return validateResult;
                }

                context.Item.Attach(item).State = EntityState.Modified;
                context.SaveChanges();

                return validateResult;
            }
            catch (Exception ex)
            {
                validateResult.MensagemErro = $"{ex.Message}";
                return validateResult;
            }
        }

        public ValidateResult RemoveItem(int id)
        {
            ValidateResult validateResult = new ValidateResult();
            try
            {
                var itemBanco = GetItemBanco(id);
                if (itemBanco == null)
                {
                    validateResult.MensagemErro = $"Item não cadastrado no banco";
                    return validateResult;
                }

                context.Item.Remove(itemBanco);

                context.SaveChanges();

                return validateResult;
            }
            catch (Exception ex)
            {
                validateResult.MensagemErro = $"{ex.Message}";
                return validateResult;
            }
        }

        private Item GetItemBanco(int id)
             => context.Item.AsNoTracking().Where(e => e.CodigoEstoque == id).FirstOrDefault();

    }
}
