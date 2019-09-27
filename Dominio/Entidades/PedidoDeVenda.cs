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
        public DateTime DataDoPedido { get; set; }
        public DateTime DataDeEntrega { get; set; }

    }
}
