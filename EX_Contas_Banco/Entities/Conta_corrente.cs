using System;

namespace EX_Contas_Banco.Entities
{
    class Conta_corrente
    {
        public string Nome { get; private set; }

        public double Valor { get; protected set; }

        public int Agencia { get; set; }

        public Conta_corrente()
        {
        }

        public Conta_corrente(string nome, double valor, int agencia)
        {
            Nome = nome;
            
            Valor = valor;

            Agencia = agencia;
        }

        //Metodo para deposito
        public double Deposito(Double deposito) 
        {
           return Valor += deposito;
        }

        //Atributo para Saque
        public void Saque(double saque)
        {
            if (saque > Valor)
            {
                Console.WriteLine("Valor de saque maior que valor em carteira!!!");
            }
            else
            {
                Valor -= saque;
            } 
        }

        //Sobrecarga de String
        public override string ToString()
        {
            return "Nome do Cliente: " + Nome + ", Número da Conta: " + Agencia + ", Valor em Carteira: " + Valor; 
        }


    }
}
