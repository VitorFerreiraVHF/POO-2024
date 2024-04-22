using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace conta_bancaria
{
    public class Caixa
    {
        public static void MenuGeral()
        {
            ContaBancaria contaBancaria1 = new ContaBancaria();

            bool loopAplicacao = true;

            while (loopAplicacao)
            {
                Console.Clear();
                Console.WriteLine("-------------- MENU GERAL --------------");
                Console.WriteLine("\n\n1 - Criar conta" + "\n2 - Depositar" + "\n3 - Sacar" + "\n4 - Obter Saldo" + "\n5 - Obter número da conta" + "\n6 - Obter número do Titular" + "\n0 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();

                            Console.WriteLine("Insira o número da conta");
                            string conta = Console.ReadLine();

                            Console.WriteLine("Insira o nome do titular da conta");
                            string titular = Console.ReadLine();

                            contaBancaria1.CadastrarConta(conta, titular);
                            Console.WriteLine("Conta criada");

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();

                            Console.WriteLine("Insira o valor a ser depositado");
                            double valor = Convert.ToDouble(Console.ReadLine());

                            contaBancaria1.Depositar(valor);

                            Console.WriteLine($"Atualmete possui {contaBancaria1.Saldo} de saldo");
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();

                            Console.WriteLine("Insira o valor a ser sacado");
                            double valor = Convert.ToDouble(Console.ReadLine());

                            contaBancaria1.Sacar(valor);

                            Console.WriteLine($"Atualmete possui {contaBancaria1.Saldo} de saldo");
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();

                            double retornoSaldo = contaBancaria1.ObterSaldo();
                            Console.WriteLine($"Atualmente seu saldo é de {retornoSaldo}");

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            string retornoConta = contaBancaria1.ObterNumeroConta();
                            Console.WriteLine($"O número da sua conta é {retornoConta}");

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();
                            string retornoTitular = contaBancaria1.ObterNumeroTitular();
                            Console.WriteLine($"O número do seu titular é {retornoTitular}");

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 0:
                        {
                            loopAplicacao = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nValor inválido!");
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                }
            }

            Console.WriteLine("\nFim da aplicação! :)");
        }
    }
}
