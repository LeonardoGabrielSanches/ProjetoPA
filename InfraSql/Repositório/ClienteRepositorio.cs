﻿using Dominio.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VendasAPI.Domínio.Entidades;
using VendasAPI.Infra.Context;

namespace VendasAPI.Infra.Repositório
    //EASTER EGG
{
    public class ClienteRepositorio : BaseValidate, IInterfaceGeral
    {
        private VendaContext context = new VendaContext();

        public Cliente GetCliente(string cliente)
        {
            Cliente clienteBD = new Cliente();
            try
            {
                clienteBD = EncontraCliente(cliente);

                if (clienteBD == null)
                    Result.MensagemErro = "Cliente não cadastrado no banco de dados";
            }
            catch (System.Exception ex)
            {
                Result.MensagemErro = "Ocorreu um erro " + ex;
            }
            return clienteBD;

        }
        public ValidateResult PostCliente(string documento)
        {
            try
            {
                var existeNoBanco = EncontraCliente(documento);
                if (existeNoBanco != null)
                {
                    Result.MensagemErro = "Cliente já existente no banco de dados";
                    return Result;
                }
                //Tipo CNPJ 
                var cliente = CrossCutting.APIExterna.APIReceitaCNPJ(documento);

                context.Cliente.Add(cliente);

                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return Result;
        }

        public ValidateResult PutCliente(Cliente cliente)
        {
            try
            {
                context.Cliente.Attach(cliente).State = EntityState.Modified;
                context.Cliente.Update(cliente);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                Result.MensagemErro = $"{ex.Message}";
            }

            return Result;
        }

        public ValidateResult RemoveCliente(string documento)
        {
            var cliente = EncontraCliente(documento);

            if (cliente != null)
            {
                context.Cliente.Remove(cliente);
                context.SaveChanges();
            }

            else
                Result.MensagemErro = "Documento não cadastrado no sistema";


            return Result;
        }

        public Cliente EncontraCliente(string cliente)
               => context.Cliente.AsNoTracking().Where(e => e.NumeroDocumento == cliente).FirstOrDefault();
    }
}
