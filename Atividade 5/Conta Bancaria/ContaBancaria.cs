using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_bancaria
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }
        public string NumeroConta { get; set; }
        public string Titular { get; set; }

        public void CadastrarConta(string numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public void Depositar(double valorDepositado)
        {
            if (valorDepositado <= 0)
            {
                Console.WriteLine("Você não pode depositar valores negativos");
            }
            else 
            {
                Saldo += valorDepositado;
            }
            
        }
        public void Sacar(double valorSaque)
        {
            if (Saldo <= 0) 
            {
                Console.WriteLine("Você não possui saldo suficiente");
            }  
            else if (Saldo < valorSaque || valorSaque < 0) 
            {
                Console.WriteLine($"Você não pode sacar esse valor, o seu saldo é de {Saldo} reais");
            } 
            else
            {
                Saldo -= valorSaque;
            }
            
        }
        public double ObterSaldo()
        {
            return Saldo;
        }
        public string ObterNumeroConta()
        {
            return NumeroConta;
        }
        public string ObterNumeroTitular()
        {
            return Titular;
        }
    }
}
