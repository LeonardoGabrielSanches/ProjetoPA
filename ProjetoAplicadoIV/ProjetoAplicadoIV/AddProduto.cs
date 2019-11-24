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
    public partial class AddProduto : Form
    {
        Verificacoes y = new Verificacoes();
        AddProdutoPedido x = new AddProdutoPedido();
        public AddProduto()
        {
            InitializeComponent();
        }

        private void txtAddProduto_CodProduto_TextChanged(object sender, EventArgs e)
        {
            if (!y.isNumber(txtAddProduto_CodProduto.Text))
            {
                MessageBox.Show("Código invalido - Apenas Inteiros!");
                txtAddProduto_CodProduto.Text = "";
            }
            else
            {
                x.SetCodigoProduto(int.Parse(txtAddProduto_CodProduto.Text));
            }

            //Buscar no BD aqui???
            


        }

        private void txtAddProduto_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if (!y.isNumber(txtAddProduto_Quantidade.Text))
            {
                MessageBox.Show("Código invalido - Apenas Inteiros!");
                txtAddProduto_Quantidade.Text = "";
            }
            else
            {
                //Buscar no BD aqui???
                /*Fazer a verificacao
                 if(int.Parse(txtAddProduto.Text) > RETORNO UNIDADE PRODUTO BD)
                    MessageBox.Show("Quantidade requisitada indisponivel");
                else
                {
                    continuar programa...
                }
                 */
            }


        }

        private AddProdutoPedido button1_Click(object sender, EventArgs e)
        {
            return x;
        }
    }
}
