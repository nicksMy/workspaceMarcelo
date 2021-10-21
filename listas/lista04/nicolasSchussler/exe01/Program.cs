// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe01
{
    class Program
    {   
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variaveis
            double saldoMedioAnual;

            // Chamada e atribuição de função
            saldoMedioAnual = leSaldoMedio("Insira seu saldo anual:");

            // Chamada de procedimento
            comparaSaldo(saldoMedioAnual);
        }
        // Criação da função
        static public double leSaldoMedio (string frase) {
            // Declaração de variaveis
            double saldoLido;

            // Exibir linha no console
            Console.WriteLine(frase);

            // Conversão e armazenamento da entrada de dado
            saldoLido = double.Parse(Console.ReadLine());

            // Retorno de dado
            return saldoLido;
        }
        // Criação do procedimento
        static public double calculaCredito (double saldo, double valorCredito) {
            // Declaração da variavel
            double porcentagem;

            // Atribuição de expressão - calculo da porcentagem
            porcentagem = (valorCredito / 100);
            valorCredito = (porcentagem * saldo);

            // Retorno de dado
            return valorCredito;
        }
        // Criação de procedimento
        static public void comparaSaldo (double saldo) {
            // Declaração de variavel
            double resultado, valorCredito;

            // Utilização de estrutura de controle
            if (saldo >= 0 && saldo <= 200) {
                // Escrevendo linha para o usuario
                Console.WriteLine("Você não possui saldo suficiente para crédito especial");
            
            // Utilização de estrutura de controle    
            } else if (saldo > 200 && saldo <= 400) {
                // Atribuição a variavel
                valorCredito = 20.0;

                // Atribuição e chamada de procedimento
                resultado = calculaCredito (saldo, valorCredito);

                // Escrevendo linha para usuario
                Console.WriteLine($"Seu saldo médio: {saldo}\nSeu crédito especial: {resultado}");

            // Utilização de estrutura de controle
            } else if (saldo > 401 && saldo <= 600) {
                // Atribuição a variavel
                valorCredito = 30.0;

                // Atribuição e chamada de procedimento
                resultado = calculaCredito (saldo, valorCredito);

                // Escrevendo linha para usuario
                Console.WriteLine($"Seu saldo médio: {saldo}\nSeu crédito especial: {resultado}");

            // Utilização de estrutura de controle
            } else if (saldo > 601) {
                // Atribuição a variavel
                valorCredito = 40.0;

                // Atribuição e chamada de procedimento
                resultado = calculaCredito (saldo, valorCredito);

                // Escrevendo linha para usuario
                Console.WriteLine($"Seu saldo médio: {saldo}\nSeu crédito especial: {resultado}");                

            // Utilização de estrutura de controle
            } else {
                // Escrevendo linha para usuario
                Console.WriteLine("Seu valor está fora do escopo!");
            }
        }
    }
}