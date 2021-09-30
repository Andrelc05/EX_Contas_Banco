using System;
using EX_Contas_Banco.Entities;

namespace EX_Contas_Banco
{
    class Program
    {
        static void Main(string[] args)
        {   //Variaveis aleatórias para setar valores iniciais
            double valor = 100.00;
            double taxa = 1;
            double deposito;
            double saque;

            Console.WriteLine("Digie os dados da conta");
            //Captura dos dados
            Console.Write("Nome do Cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            //Escolher o tipo de conta
            Console.Write("Conta Corrente ou Poupança? C/P: ");
            char TipoConta = char.Parse(Console.ReadLine());
            //Logica para cada tipo de conta
            if (TipoConta == 'C' || TipoConta == 'c')
            {
                Conta_corrente ContaC = new Conta_corrente(nome, valor, numero);
                Console.WriteLine();
                Console.Write($"Valor em Carteira: {ContaC.Valor}");
                Console.WriteLine();
                Console.Write("Valor de Deposito: ");
                deposito = double.Parse(Console.ReadLine());
                ContaC.Deposito(deposito);
                Console.Write($"Valor em Carteira: {ContaC.Valor}");
                Console.WriteLine();
                Console.Write("Valor para ser sacado: ");
                saque = double.Parse(Console.ReadLine());
                ContaC.Saque(saque);
                Console.Write("Dados de Saída: ");
                //Uma sobrecarga foi feita na classe Conta_corrente
                Console.WriteLine(ContaC);
            }

            else if (TipoConta == 'P' || TipoConta == 'p')
            {
                Conta_poupanca ContaP = new Conta_poupanca(nome, valor, numero, taxa);
                Console.WriteLine();
                Console.Write($"Valor em Carteira: {ContaP.Valor}");
                Console.WriteLine();
                Console.Write("Valor de Deposito: ");
                deposito = double.Parse(Console.ReadLine());
                ContaP.Deposito(deposito);
                Console.Write($"Valor em Carteira: {ContaP.Valor}");
                Console.WriteLine();
                Console.Write("Valor para ser sacado: ");
                saque = double.Parse(Console.ReadLine());
                ContaP.Saque(saque);
                ContaP.CalTaxa();
                Console.WriteLine("Dados de Saída: ");
                Console.WriteLine($"Nome do Cliente: {ContaP.RetornarNome()}, Número da Conta: {ContaP.Agencia}, Valor em Carteira: {ContaP.Valor}");
            }
        }

    }
}