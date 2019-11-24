using ProjetoAplicadoIV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAplicadoIV
{
    public partial class Form1 : Form
    {
        DateTime data_hora;
        Verificacoes x = new Verificacoes();

        public Form1()
        {
            InitializeComponent();
            pnlCadastrarCliente.Visible = false;
            pnlCadastrarProduto.Visible = false;
            pnlPedido.Visible = false;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lbl_Data_Hora.Text = data_hora.ToLongDateString() + " | " + data_hora.ToLongTimeString();
        }


        /*PANEL PEDIDO----------------------------------------------------*/

        private void lblPedido_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
            pnlCadastrarProduto.Visible = false;
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
            pnlCadastrarProduto.Visible = false;
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
            pnlCadastrarProduto.Visible = false;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(DialogResult.Yes != MessageBox.Show("Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)))
            {
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPedido.Visible = true;
            pnlPedido.BringToFront();


            //Pegar o ultimo código de pedido -> Somar 1 e criar um pedido com esse nome
        }

        private void btnPedido_Fechar_Click(object sender, EventArgs e)
        {
            
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão
            if (!(DialogResult.Yes != MessageBox.Show("Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)))
            {
                //Cancelar o evento
                //MANDAR TUDO PARA O BANCO AQUII!!!
                double frete, desconto;
                if (txtPedido_Frete.Text.Equals(""))
                    frete = 0;
                if (txtPedido_Desconto.Text.Equals(""))
                    desconto = 0;


                txtPedido_CodCliente.Text = "";
                txtPedido_Codigo.Text = "";
                txtPedido_Desconto.Text = "";
                txtPedido_Frete.Text = "";
                txtPedido_NomeCliente.Text = "";
                txtPedido_ValorTotal.Text = "";
                pnlPedido.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verifica se o comboBox não possui forma de pagamento adequada
            if (!cmbPedido_FormaPagamento.Text.Equals("Dinheiro") 
                && !cmbPedido_FormaPagamento.Text.Equals("Crédito") 
                && !cmbPedido_FormaPagamento.Text.Equals("Débito"))
            {
                MessageBox.Show("Forma de pagamento inválida!");
            }
        }

        private void txtPedido_CodCliente_TextChanged(object sender, EventArgs e)
        {
            if (!x.isNumber(txtPedido_CodCliente.Text))
            {
                MessageBox.Show("Código invalido - Apenas Inteiros!");
                txtPedido_CodCliente.Text = "";
            }
                
        }

        private void txtPedido_Frete_TextChanged(object sender, EventArgs e)
        {
            if (!x.isNumber(txtPedido_Frete.Text))
            {
                MessageBox.Show("Código invalido - Apenas Inteiros!");
                txtPedido_Frete.Text = "";
            }
        }

        private void txtPedido_Desconto_TextChanged(object sender, EventArgs e)
        {
            if (!x.isNumber(txtPedido_Desconto.Text))
            {
                MessageBox.Show("Código invalido - Apenas Inteiros!");
                txtPedido_Desconto.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        /*PANEL PEDIDO------------------------FINAL--------------------*/

        /*PANEL PRODUTO------------------------COMEÇO--------------------*/

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCadastrarProduto.BringToFront();
            pnlCadastrarProduto.Visible = true;
            pnlCadastrarProduto.Enabled = true;
        }

        private void btnProduto_Salvar_Click(object sender, EventArgs e)
        {
            if (!x.isNumber(txtProduto_Codigo.Text) || !x.isNumber(txtProduto_Custo.Text)
                || !x.isNumber(txtProduto_Descricao.Text) || !x.isNumber(txtProduto_EmEstoque.Text)
                || !x.isNumber(txtProduto_Margem.Text) || !x.isNumber(txtProduto_MinimoVenda.Text)
                || !x.isNumber(txtProduto_VendaPadrao.Text))
            {
                MessageBox.Show("Verifique os campos de texto");
            }
        }

        private void txtProduto_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlCadastrarProduto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCliente_CNPJ_TextChanged(object sender, EventArgs e)
        {
            int cont = 0;
            foreach(Char i in txtCliente_CNPJ.Text)
            {
                cont++;
                if(i<48 || i>57)
                {
                    txtCliente_CNPJ.Text.Remove(i);
                }
                if (cont > 11)
                {
                    MessageBox.Show("Maximo 11 digitos");
                    txtCliente_CNPJ.Text.Remove(i);
                }
                    
            }
        }

        private void btnCliente_Salve_Click(object sender, EventArgs e)
        {
            ApiRest.CadastraCliente(txtCliente_CNPJ.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(DialogResult.Yes != MessageBox.Show("Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)))
            {
                //Cancelar o evento
                //MANDAR TUDO PARA O BANCO AQUII!!!
                txtCliente_CNPJ.Text = "";
                txtCliente_Razao.Text = "";
                pnlCadastrarCliente.Visible = false;
            }
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCadastrarCliente.Visible = true;
            pnlCadastrarCliente.BringToFront();
        }
        /*PANEL PRODUTO------------------------FINAL--------------------*/
    }
}
