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

namespace frmSistema
{
    public partial class Form1 : Form
    {
        DateTime dataHora;

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
            pnlCliente.Visible = true;
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
            pnlCliente.Visible = false;
            pnlMenu.Visible = false;
            pnlProduto.Visible = true;
        }

        private void criarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            pnlProduto.Visible = false;
            pnlMenu.Visible = false;
            pnlPedido.Visible = true;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            pnlProduto.Visible = false;
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
            FecharAlgo(1);
        }

        //Cadastrar Produto 
        private void btnProduto_Cadastrar_Click(object sender, EventArgs e)
        {
            

            //Verificando se os campos de valor são realmente números
            if (isNumber(txtProduto_Custo.Text) && isNumber(txtProduto_Margem.Text))
            {
                //Se forem manda para o BD
                int codigo = int.Parse(txtProduto_Codigo.Text);
                string descricao = txtProduto_Descricao.Text;
                string marca = txtProduto_Marca.Text;
                double custo = double.Parse(txtProduto_Custo.Text);
                double margem = double.Parse(txtProduto_Margem.Text); //Em porcentagem
                double venda = custo + (custo * margem / 100);
                txtProduto_Venda.Text = "R$" + venda.ToString("F2");


                //Esses acima são as variáveis para mandar para o BD
                MessageBox.Show("Sucesso!");
            }
            else
                MessageBox.Show("Verifique os campos de texto e valor!");

        }

        //Cadastrar Cliente
        private void btnCliente_Cadastrar_Click(object sender, EventArgs e)
        {
            //Arrumando cnpj para apenas numeros
            string CNPJapenasNumeros = Regex.Replace(txtCliente_CNPJ.Text, "[^0-9]", "");

            if(!isNumber(CNPJapenasNumeros))
            {
                MessageBox.Show("Verifique o campo de text - Válido apenas números!");
            }
            else
            {
                //Fazer a mágica acontecer aqui! hehe




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

        //Metodos Criados Manualmente ******************************************
        private void FecharAlgo(int x)
        {
            //Fechar algum panel
            if (x == 1)
            {
                if (!(DialogResult.Yes != MessageBox.Show("Nada será salvo caso ainda não tenha cadastrado. Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)))
                {
                    //Voltar para o menu
                    pnlCliente.Visible = false;
                    pnlProduto.Visible = false;
                    pnlPedido.Visible = false;
                    pnlMenu.Visible = true;
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

        private void txtProduto_Margem_TextChanged(object sender, EventArgs e)
        {
            txtProduto_Margem.Text.Replace(".", ",");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCliente_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
