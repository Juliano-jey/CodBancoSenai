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
            this.saldo += valor;
        }
        public void Debito(double valor)
        {
            if (valor >this.saldo)
            {
                throw new Exception("Insira um valor <Saldo");
            }
            this.saldo -= valor;
        }
    }
}
