// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe03
{
    class Program

    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declração de variaveis
            double saldo, valorOperacao;
            string operacao;    

            // Escrever tipos de operações possíveis
            Console.WriteLine("OPERAÇÕES POSSÍVEIS\nretirada    e   deposito");

            // Atribuição e chamada de funções
            saldo = leValor("Digite o valor do seu saldo: ");
            operacao = leOperacao("Digite o tipo de operação: ");
            valorOperacao = leValor("Digite o valor da sua operação bancaria: ");

            // Chamada de procedimento
            fazOperacao(saldo, valorOperacao, operacao);
        }
        // Criação de função
        static public double leValor (string frase) {
            // Declaração de variavel
            double valorLido;

            // Exibição de linha para o usuario
            Console.WriteLine(frase);

            // Conversão e armazenamento de dado de entrada
            valorLido = double.Parse(Console.ReadLine());

            // Retorno de dado
            return valorLido;
        }

        // Criação de função
        static public string leOperacao (string frase) {
            // Declaração de variavel
            string operacaoLida;

            // Exibição de linha para o usuario
            Console.WriteLine(frase);

            // Conversão e armazenamento de dado de entrada
            operacaoLida = Convert.ToString(Console.ReadLine());

            // Retorno de dado
            return operacaoLida;
        }
        // Criação de procedimento
        static public void fazOperacao (double saldo, double valorOperacao, string operacao) {
            // Utilização de estrutura de controle
            if (operacao == "deposito") {
                // Declaração de variavel
                double saldoAtual;

                // Atribuição de expressão
                saldoAtual = (saldo + valorOperacao);

                // Exibição de linha para o usuario
                Console.WriteLine($"Seu saldo atual ficou: {saldoAtual}");
            // Utilização de estrutura de controle
            } else if (operacao == "retirada") {
                // Declaração de variavel
                double saldoAtual;

                // Atrbuição de expressão
                saldoAtual = (saldo - valorOperacao);

                // Utilização de estrutura decontrole
                if (saldoAtual < 0) {
                    // Exibição de linha para o usuario
                    Console.WriteLine("Sua conta está estourada!");
                // Utilização de estrutura de controle
                } else {
                    // Exibição de linha para o usuario
                    Console.WriteLine($"Seu saldo atual ficou: {saldoAtual}");
                }
            // Utilização de estrutura de controle
            } else {
                // Exibição de linha para o usuario
                Console.WriteLine("OPERAÇÃO OU VALORES INCORRETOS\nDigite os valores e a operação novamente.");
            }
        }
    }
}
