using Newtonsoft.Json;
using System.Net.Http;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Infra.CrossCutting
{
    public class APIExterna
    {
        public static Cliente APIReceitaCNPJ(string cnpj)
        {
            try
            {
                HttpClient client = new HttpClient();

                var respostaAPI = client.GetAsync("https://www.receitaws.com.br/v1/cnpj/" + cnpj).Result;

                if (!respostaAPI.IsSuccessStatusCode)
                    return null;

                var infosAPI = respostaAPI.Content.ReadAsStringAsync().Result;

                Cliente cliente = JsonConvert.DeserializeObject<Cliente>(infosAPI);
                cliente.NumeroDocumento = cnpj;
                cliente.TipoDocumento = "CNPJ"; //essas linhas poderão ser comentadas , tudo vai depender da estrutura.

                return cliente;
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        public ValidateResult ValidaSeCnpjExiste()
        {
            ValidateResult result = new ValidateResult();
            //CHAMAR NA ENTIDADE AS VALIDAÇOES.
            return result;
        }


    }
}
