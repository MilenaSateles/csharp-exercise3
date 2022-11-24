using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main (string [] args)
        {
            ContaBancaria conta;
            
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine()!);
            Console.Write("Entre o titular da conta: ");
            string titular = (Console.ReadLine()!);
            Console.Write("Haverá depósito inicial (s/n)? ");
            char simOuNao = char.Parse(Console.ReadLine()!);

            if (simOuNao == 's' || simOuNao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, titular, depositoInicial);
            }

            else
                conta = new ContaBancaria(numeroConta, titular);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}