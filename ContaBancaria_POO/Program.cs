using System;
using System.Globalization;

namespace ProjetoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variavél para fazer instanciação dentro da condição IF/ELSE
            ContaBancaria conta;

            // Inserir os dados do usuário (Nº Conta,   Nome e  Saldo)
            Console.Write("Insira o número da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Insira o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (Responder com S ou N)");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor do depósito inicial:");
                double depositoInical = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInical);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            // Depósito (Chamo o objeto conta e operação do método deposito 
            Console.WriteLine();
            Console.Write("Digite o valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            // Saque (Chamo o objeto conta e operação do método saque
            Console.WriteLine();
            Console.Write("Digite o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
        }
    }
}
