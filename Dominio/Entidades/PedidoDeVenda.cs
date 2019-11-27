using System;
using System.Collections.Generic;
using VendasAPI.Domínio.Entidades;

namespace Dominio.Entidades
{
    public class PedidoDeVenda
    {
        public int VendaId { get; set; }
        public List<Item> ListaDeItem { get; set; }
        public double PrecoFinal { get; set; }
        public double Desconto { get; set; }
        public Vendedor Vendedor { get; set; }
        public string FormaPagamento { get; set; }//Criei forma de pagamento
        public DateTime DataDoPedido { get; set; }
        public DateTime DataDeEntrega { get; set; }

        public PedidoDeVenda()
        {
            PrecoFinal = 0;
        }

        public double GetPrecoFinal()
        {
            return PrecoFinal;
        }

        public void SetPrecoFinal(double preco)
        {
            PrecoFinal += preco;
        }
    }
}
