using System;
using System.Collections.Generic;
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

        public List<Item> GetAllItem()
        {
            try
            {
                return context.Item.AsNoTracking().Where(e => !string.IsNullOrEmpty(e.Descricao)).ToList();
            }
            catch
            {
                
            }

            return null;
        }

        public Item GetItem(string descricao)
        {
            try
            {
                var item = GetItemBanco(descricao);

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

                var itemBanco = GetItemBanco(item.Descricao);

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
                var itemBanco = GetItemBanco(item.Descricao);
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
                var itemBanco = GetItemBanco(id.ToString());
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

        private Item GetItemBanco(string descricao)
             => context.Item.AsNoTracking().Where(e => e.Descricao == descricao).FirstOrDefault();

    }
}
