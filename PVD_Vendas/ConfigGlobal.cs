using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_Vendas
{
    class Banco
    {
        public SqlConnection connection = new SqlConnection();

        public void conectar()
        {
            connection.ConnectionString = ("Data Source=(local);Initial Catalog=DatabaseHighData;Integrated Security=True");
            connection.Open();
        }

        public void desconectar()
        {
            connection.Close();
        }
    }

    public class sacolaVenda
    {
        static bool Validacao = false;

        public static void receberDados(bool validacao)
        {
            Validacao = validacao;
        }

        public static bool _retornarValidacao()
        {
            return Validacao;
        }
    }

    public class alertValidation
    {
        static bool Validacao = false;
        static int Operacao;

        public static void receberDados(bool validacao)
        {
            Validacao = validacao;
        }

        public static bool _retornarValidacao()
        {
            return Validacao;
        }


        public static void receberOperacao(int codigo)
        {
            Operacao = codigo;
        }

        public static int _retornarOperacao()
        {
            return Operacao;
        }
    }
}
