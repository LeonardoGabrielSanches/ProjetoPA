﻿//O QUE FALTA MAIS ? RETIRAR O COMENTÁRIO APOS FAZER AS ALTERAÇÕES
namespace VendasAPI.Domínio.Entidades
{
    public class Item
    { 

        public int ItemID { get; set; }
        public int CodigoEstoque { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double ValorCusto { get; set; }
        public double ValorVenda { get; set; }
        public double MargemMaxima { get; set; }

        public Item(string descricao, string marca, double valorCusto, double valorVenda, double margemMaxima)
        {
            Descricao = descricao;
            Marca = marca;
            ValorCusto = valorCusto;
            ValorVenda = valorVenda;
            MargemMaxima = margemMaxima;
        }
    }
}
