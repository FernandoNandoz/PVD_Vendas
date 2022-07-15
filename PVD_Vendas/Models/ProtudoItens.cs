using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_Vendas.Models
{
    public class ProtudoItens
    {
        static bool ItemEncontrado = false;
        static int IdProduto = 0;
        static string NomeProduto;
        static int Quantidade = 1;
        static decimal ValorUnitario = 0;

        public static void receberValidacao(bool validacao)
        {
            ItemEncontrado = validacao;
        }

        public static bool _ItemEncontrado()
        {
            return ItemEncontrado;
        }

        public static void receberProdutoItem(int ID, string produto, int quantidade, decimal valorUnitario)
        {
            IdProduto = ID;
            NomeProduto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public static int _IdProduto()
        {
            return IdProduto;
        }

        public static string _NomeProduto()
        {
            return NomeProduto;
        }

        public static int _Quantidade()
        {
            return Quantidade;
        }

        public static decimal _ValorUnitario()
        {
            return ValorUnitario;
        }
    }
}
