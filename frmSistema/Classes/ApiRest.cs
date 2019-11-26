using Dominio.Entidades;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using VendasAPI.Domínio.Entidades;

namespace ProjetoAplicadoIV.Classes
{
    public class ApiRest
    {

        public static async void CadastraCliente(string cnpj)
        {
            

            HttpClient client = new HttpClient();

            var respostaAPI = client.GetAsync("https://localhost:44308/api/Cliente?documento=" + cnpj).Result;

            if (!respostaAPI.IsSuccessStatusCode)
                MessageBox.Show("Não foi possível fazer o cadastro");
            else
                MessageBox.Show("Cliente cadastrado com sucesso");

            //var infosAPI = respostaAPI.Content.ReadAsStringAsync().Result;

            //Cliente cliente = JsonConvert.DeserializeObject<Cliente>(infosAPI);
        }

        public static async void CadastraProduto(Item produto)//Necessita teste
        {
            HttpClient client = new HttpClient();

            var httpContent = new StringContent(produto.ToString(), Encoding.UTF8, "application/json");


            var respostaApi = client.PostAsync("https://localhost:44308/api/Item", httpContent).Result;

            if (!respostaApi.IsSuccessStatusCode)
                MessageBox.Show("Não foi possível cadastrar o produto");
            else
                MessageBox.Show(respostaApi.Content.ReadAsStringAsync().Result);
        }

        public static async void CadastraPedido(PedidoDeVenda pedido)//Mesma coisa objeto já feito
        {
            HttpClient client = new HttpClient();

            var httpContent = new StringContent(pedido.ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage respostaApi = client.PostAsync("https://localhost:44308/api/PedidoDeVenda", httpContent).Result;

            if (!respostaApi.IsSuccessStatusCode)
                MessageBox.Show("Não foi possível cadastrar o produto");
            else
                MessageBox.Show(respostaApi.Content.ReadAsStringAsync().Result);
        }


    }
}
