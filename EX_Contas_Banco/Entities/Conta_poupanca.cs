using System;


namespace EX_Contas_Banco.Entities
{
    class Conta_poupanca : Conta_corrente
    {
        public double Taxa { get; private set; }

        //Contrutor padrão
        public Conta_poupanca()
        {
        }

        public Conta_poupanca(string nome, double valor, int agencia, double taxa):base(nome, valor, agencia)
        {
            Taxa = taxa;
        }

        //Atributo para Calcular a taxa da poupança
        public void CalTaxa() 
        {
             Valor += (Valor * Taxa * 0.1);
        }

        //Metodo para retornar o nome (Apenas para completar a quantidade minima de metodos) mas não precisaria disso!!!
        public string RetornarNome()
        {
            return Nome;        
        }



    }
}
