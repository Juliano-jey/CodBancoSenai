using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;


        public void Credito(double valor)
        {

            if (valor <= 0)
            {
                throw new Exception("Insira um valor >0");
            }
            Conexao conexao = new Conexao();
            string query = "INSERT INTO movimentacao (operacao, valor) VALUES (@valor1, @valor2)";
            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@valor1", "credito"),
                new MySqlParameter("@valor2", valor),
            };
            conexao.ExecuteQueryWithParameters(query,param);

            this.saldo += valor;

        }
        public void Debito(double valor)
        {
            if (valor > this.saldo || valor <= 0)
            {
                throw new Exception("Insira um valor <Saldo e >0");
            }
            Conexao conexao = new Conexao();
            string query = "INSERT INTO movimentacao (operacao, valor) VALUES (@valor1, @valor2)";
            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@valor1", "debito"),
                new MySqlParameter("@valor2", valor),
            };
            conexao.ExecuteQueryWithParameters(query, param);
            this.saldo -= valor;
        }
    }
}
