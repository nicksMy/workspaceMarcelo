// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe04
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variavel
            double N;

            // Atribuição e chamada de função
            N = leNumero("Digite um valor númerico: ");

            // Chamada de procedimento
            comparaNumero(N);

        }
        // Criação de função
        static public double leNumero (string frase) {
            // Declaração de variavel
            double numeroLido;

            // Escrever linha para o usuario
            Console.WriteLine(frase);

            // Conversão e armazenamneto do dado de entrada
            numeroLido = Convert.ToDouble(Console.ReadLine());

            // Retorno de valor da variavel
            return numeroLido;

        }
        // Criação de procedimento
        static public void comparaNumero (double N) {
            // Utilizando estrutura de controle
            if (N <= 10)
            // Escrever linha para o usuario
            Console.WriteLine("F1");
            
            // Utilizando estrutura de controle
            else if (N > 10 && N <= 100)
            // Escrever linha para o usuario
            Console.WriteLine("F2");

            // Utilizando estrutura de controle
            else if (N > 100)
            // Escrever linha para o usuario
            Console.WriteLine("F3");
        }
    }
}
