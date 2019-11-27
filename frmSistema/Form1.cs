using Dominio.Entidades;
using VendasAPI.Domínio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAplicadoIV.Classes;

namespace frmSistema
{
    public partial class Form1 : Form
    {
        DateTime dataHora;
        private object listaItens;
        List<Item> listaProduto = new List<Item>();
        PedidoDeVenda auxPedido = new PedidoDeVenda();
        List<GridView> gridViewAUX = new List<GridView>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataHora = DateTime.Now;
            lblMenu_HoraData.Text = dataHora.ToLongDateString() + " | " + dataHora.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
            pnlProduto.Visible = false;
            pnlMenu.Visible = false;
            pnlConsultarPedidos.Visible = false;
            pnlCliente.Visible = true;

            txtCliente_Nome.Visible = false;
            txtCliente_Codigo.Visible = false;
            txtCliente_Nome.Text = "";
            txtCliente_Codigo.Text = "";
            txtCliente_CNPJ.Text = "";
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
            pnlCliente.Visible = false;
            pnlMenu.Visible = false;
            pnlConsultarPedidos.Visible = false;
            pnlProduto.Visible = true;

            txtProduto_Codigo.Visible = false;
            txtProduto_Codigo.Text = "";
            txtProduto_Custo.Text = "";
            txtProduto_Descricao.Text = "";
            txtProduto_Marca.Text = "";
            txtProduto_Margem.Text = "";
            txtProduto_Venda.Text = "";

        }

        private void criarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            pnlProduto.Visible = false;
            pnlConsultarPedidos.Visible = false;
            pnlMenu.Visible = false;
            pnlPedido.Visible = true;

            DateTime criacaoPedido = dataHora;
            string data = criacaoPedido.ToShortDateString();
            string hora = criacaoPedido.ToLongTimeString();

            auxPedido = new PedidoDeVenda();
            var listaAuxGrid = new List<GridView>();

            auxPedido.DataDoPedido = criacaoPedido;

            auxPedido.ListaDeItem = new List<Item>();

            txtPedido_Hora.Text = hora;
            txtPedido_Data.Text = data;

            listaProduto = null;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            pnlProduto.Visible = false;
            pnlConsultarPedidos.Visible = false;
            pnlPedido.Visible = false;
            pnlMenu.Visible = true;

        }

        private void btnProduto_Voltar_Click(object sender, EventArgs e)
        {
            FecharAlgo(1);
        }

        private void btnCliente_Voltar_Click(object sender, EventArgs e)
        {
            FecharAlgo(1);
        }

        private void btnPedido_Voltar_Click(object sender, EventArgs e)
        {
            auxPedido = null;
            FecharAlgo(1);
        }

        //Cadastrar Produto 
        private void btnProduto_Cadastrar_Click(object sender, EventArgs e)
        {


            //Verificando se os campos de valor são realmente números
            if (isNumber(txtProduto_Custo.Text) && isNumber(txtProduto_Margem.Text))
            {

                //Se forem manda para o BD
                //int codigo = int.Parse(txtProduto_Codigo.Text);
                string descricao = txtProduto_Descricao.Text;
                string marca = txtProduto_Marca.Text;
                double custo = double.Parse(txtProduto_Custo.Text);
                double margem = double.Parse(txtProduto_Margem.Text); //Em porcentagem
                double venda = custo + (custo * margem / 100);
                txtProduto_Venda.Text = "R$" + venda.ToString("F2");

                Item item = new Item(descricao, marca, custo, margem, venda);

                //Cadastrando o item
                string codigoFinal = ApiRest.CadastraProduto(item).ToString();

                if (string.IsNullOrEmpty(codigoFinal))
                {
                    txtProduto_Codigo.Text = codigoFinal;//Passar o ID do produto gerado no banco

                    MessageBox.Show("Sucesso!");

                }
                else
                    MessageBox.Show("Falha no salvamento");

            }
            else
                MessageBox.Show("Verifique os campos de texto e valor!");

        }

        //Cadastrar Cliente
        private void btnCliente_Cadastrar_Click(object sender, EventArgs e)
        {
            //Arrumando cnpj para apenas numeros
            string CNPJapenasNumeros = arrumaCNPJ(txtCliente_CNPJ.Text);

            if (!isNumber(CNPJapenasNumeros))
            {
                MessageBox.Show("Verifique o campo de text - Válido apenas números!");
            }
            else
            {
                //Fazer a mágica acontecer aqui! hehe
                string cliente = ApiRest.CadastraCliente(CNPJapenasNumeros).ToString();
                if (!string.IsNullOrEmpty(cliente))
                {
                    string[] clienteSeparado = cliente.Split(',');
                    txtCliente_Nome.Enabled = true;
                    txtCliente_Nome.Visible = true;
                    txtCliente_Nome.Text = clienteSeparado[0];

                    txtCliente_Codigo.Enabled = true;
                    txtCliente_Codigo.Visible = true;
                    txtCliente_Codigo.Text = clienteSeparado[1];

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                    MessageBox.Show("Falha no cadastro");

            }

        }

        private void txtProduto_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProduto_Custo_TextChanged(object sender, EventArgs e)
        {
            txtProduto_Custo.Text = txtProduto_Custo.Text.Replace(".", ",");
        }

        private void txtProduto_Venda_TextChanged(object sender, EventArgs e)
        {
            txtProduto_Venda.Text = txtProduto_Venda.Text.Replace(".", ",");
        }

        private void btnPedido_IncluirItem_Click(object sender, EventArgs e)
        {
            if (txtPedido_CodigoProduto.Text.Equals("") || !isNumber(txtPedido_CodigoProduto.Text) || !isNumber(txtPedido_Quantidade.Text))
            {
                MessageBox.Show("Verifique os campos de incluir produto");
            }
            else
            {
                int codigoproduto = int.Parse(txtPedido_CodigoProduto.Text);
                int quantidade = int.Parse(txtPedido_Quantidade.Text);
                //mandar para o banco de dados o codigoproduto e retornar um produto
                Item novo = ApiRest.RecuperaItemID(codigoproduto);//Receber do banco de dados
                auxPedido.FormaPagamento = "";//RECEBER FORMA DE PAGAMENTO DO BANCO DE DADOS
                auxPedido.Vendedor = null;
                auxPedido.Desconto = 0;
                auxPedido.PrecoFinal = novo.ValorVenda * quantidade;//Somando valor da venda
                auxPedido.ListaDeItem.Add(novo);//ADICIONANDO NOVO ITEM NA LISTA

                var grid = new GridView(codigoproduto, novo.Descricao, quantidade, auxPedido.PrecoFinal);

                gridViewAUX.Add(grid);

                txtPedido_ValorTotal.Text = "R$" + auxPedido.PrecoFinal.ToString("F2");

                gridViewPedido.DataSource = gridViewAUX;
            }
        }

        public class GridView
        {
            int Codigo;
            String Descricao;
            int Quantidade;
            double PrecoFinal;

            public GridView(int codigo, string descricao, int quantidade, double precoFinal)
            {
                Codigo = codigo;
                Descricao = descricao;
                Quantidade = quantidade;
                PrecoFinal = precoFinal;
            }
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlConsultarPedidos.Visible = true;
            pnlCliente.Visible = false;
            pnlProduto.Visible = false;
            pnlPedido.Visible = false;
            pnlMenu.Visible = false;
        }

        private void txtCliente_CNPJ_TextChanged(object sender, EventArgs e)
        {
            txtCliente_CNPJ.Text = arrumaCNPJ(txtCliente_CNPJ.Text);
        }


        private void txtProduto_Margem_TextChanged(object sender, EventArgs e)
        {
            txtProduto_Margem.Text.Replace(".", ",");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCliente_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCliente_Limpar_Click(object sender, EventArgs e)
        {
            txtCliente_CNPJ.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtProduto_Codigo.Text = "";
            txtProduto_Custo.Text = "";
            txtProduto_Descricao.Text = "";
            txtProduto_Marca.Text = "";
            txtProduto_Margem.Text = "";
            txtProduto_Venda.Text = "";
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPedido_Fechar_Click(object sender, EventArgs e)
        {
            if (auxPedido != null)
            {
                ApiRest.CadastraPedido(auxPedido);
            }

            FecharAlgo(2);
            auxPedido = null;
        }

        //Metodos Criados Manualmente ******************************************
        private string arrumaCNPJ(string x)
        {
            return Regex.Replace(x, "[^0-9]", "");
        }

        private void FecharAlgo(int x)
        {
            //Fechar algum panel
            if (x == 1)//Fechar Pedido
            {
                if (!(DialogResult.Yes != MessageBox.Show("Nada será salvo caso ainda não tenha cadastrado. Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)))
                {
                    //Voltar para o menu
                    txtPedido_CNPJ.Text = "";
                    txtPedido_CodigoProduto.Text = "";
                    txtPedido_Data.Text = "";
                    txtPedido_Hora.Text = "";
                    txtPedido_Nome.Text = "";
                    txtPedido_PedidoID.Text = "";
                    txtPedido_ValorTotal.Text = "";

                    pnlCliente.Visible = false;
                    pnlProduto.Visible = false;
                    pnlPedido.Visible = false;
                    pnlConsultarPedidos.Visible = false;
                    pnlMenu.Visible = true;
                    //PedidoDeVenda pedido = new PedidoDeVenda();
                    //Item item = new Item();
                    //item.Descricao = "bla";
                    //pedido.ListaDeItem.Add(item);
                    //Convert.ToDateTime(txt);
                    //Cliente cliente = new Cliente();
                    //cadastra(cliente);
                }
            }
            if (x == 2)//Fechar Pedido
            {
                if (!(DialogResult.Yes != MessageBox.Show("O pedido será fechado, impossibilitando mudanças posteriores. Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)))
                {
                    MessageBox.Show("GRAVEI NO BANCO O PEDIDO FODASE");
                    txtPedido_PedidoID.Visible = true;
                    //txtPedido_PedidoID.Text = ;//Puxar o ID do pedido do banco aqui
                }
            }
        }

        //Verificar se é número
        private Boolean isNumber(string x)
        {
            bool verifica = true;
            //Trocar ponto por virgula (Se necessário)
            x.Replace(".", ",");

            foreach (char letra in x)
            {
                if (letra < 48 && letra != 44 || letra > 57)
                {
                    verifica = false;
                }
            }
            return verifica;
        }

        private void btnConsulta_ListarTodos_Click(object sender, EventArgs e)
        {
            // listaProduto = ; //PUXAR DO BANCO DE DADOS E FAZER APARECER NO GridViewConsulta
        }

        private void btnConsulta_Pesquisa_Click(object sender, EventArgs e)
        {
            string descricao = txtConsulta_Descricao.Text;

            Item oItem = ApiRest.RecuperaItem(descricao);//Retornar do banco de dados e fazer aparecer no GridViewConsulta
        }
    }
}
