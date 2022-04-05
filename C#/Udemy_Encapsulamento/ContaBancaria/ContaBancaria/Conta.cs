using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public Conta() { 
        }

        public Conta(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;            
        }        

        public void Depositar(decimal valor) {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public override string ToString() {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo}";            
        }
    }
}