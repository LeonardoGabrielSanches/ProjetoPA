using Dominio.Entidades;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasAPI.Domínio.Entidades;

namespace ProjetoAplicadoIV.Classes
{
    public class ApiRest
    {

        public static string CadastraCliente(string cnpj)
        {
            //string cnpjSemPontuacao = RefatoraCnpj(cnpj);

            HttpClient client = new HttpClient();

            var httpContent = new StringContent(string.Empty, Encoding.UTF8, "application/json");

            var respostaAPI = client.PostAsync("https://localhost:44308/api/Cliente?documento=" + cnpj,httpContent).Result;

            if (!respostaAPI.IsSuccessStatusCode)
                return string.Empty;
            else
                return respostaAPI.Content.ReadAsStringAsync().Result;

        }

        public static  string CadastraProduto(Item produto)//Necessita teste
        {
            HttpClient client = new HttpClient();

            var httpContent = new StringContent(produto.ToString(), Encoding.UTF8, "application/json");

            var respostaApi = client.PostAsync("https://localhost:44308/api/Item", httpContent).Result;

            if (!respostaApi.IsSuccessStatusCode)
                return string.Empty;
            else
                return respostaApi.Content.ReadAsStringAsync().Result;
        }

        public static  void CadastraPedido(PedidoDeVenda pedido)//Mesma coisa objeto já feito
        {
            HttpClient client = new HttpClient();

            var httpContent = new StringContent(pedido.ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage respostaApi = client.PostAsync("https://localhost:44308/api/PedidoDeVenda", httpContent).Result;

            if (!respostaApi.IsSuccessStatusCode)
                MessageBox.Show("Não foi possível cadastrar o produto");
            else
                MessageBox.Show(respostaApi.Content.ReadAsStringAsync().Result);
        }

        public static  List<Item> RecuperaItens()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage respostaApi = client.GetAsync("https://localhost:44308/api/PedidoDeVenda").Result;

            string listaApi = string.Empty;

            if (!respostaApi.IsSuccessStatusCode)
                MessageBox.Show("Não foi possível recuperar os dados");
            else
                 listaApi = respostaApi.Content.ReadAsStringAsync().Result;

            return null;
        }

        public static Item RecuperaItem(string descricao)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage respostaApi = client.GetAsync("https://localhost:44308/api/PedidoDeVenda/descricao").Result;

            if (!respostaApi.IsSuccessStatusCode)
                MessageBox.Show("Não foi possível recuperar os dados");
            else
            {
                var item = JsonConvert.DeserializeObject<Item>(respostaApi.Content.ReadAsStringAsync().Result);
                return item;
            }
            

            return null;
        }

    }
}
