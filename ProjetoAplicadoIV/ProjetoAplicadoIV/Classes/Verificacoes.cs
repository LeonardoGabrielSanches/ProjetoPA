using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAplicadoIV.Classes
{
    public class Verificacoes
    {
        //Muda o ponto para virgula - Arrumar números decimais para jogar ao banco de dados
        public string changeDot(string x)
        {
            return x.Replace(".", ",");
        }
    
        //Verifica se a string é um número
        public Boolean isNumber(string x)
        {
            x.Replace(".", ",");

            foreach (char i in x)
            {
                if (i < 48 && i != 54 || i > 57)
                    return false;
            }
            return true;
        }

        public static string RefatoraCnpj(string cnpj)
            =>Regex.Replace(cnpj, "[^0-9]", "");
        
    }
}
