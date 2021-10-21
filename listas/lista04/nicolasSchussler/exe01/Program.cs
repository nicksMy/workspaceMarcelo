// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe01
{
    class Program
    {   
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variaveis
            double credito, saldoMedioAnual;

            // Chamada e atribuição de função
            credito = leSaldoMedio("Insira seu saldo anual:");
        }

        // Criação da função
        static public double leSaldoMedio (string frase) {
            // Declaração de variaveis
            double saldoLido, valorCredito, creditoEspecial;

            // Exibir linha no console
            Console.WriteLine(frase);

            // Conversãoe e armazenamento da entrada de dado
            saldoLido = double.Parse(Console.ReadLine());

            // Retorno de dado
            return saldoLido;
        }
    }
}
