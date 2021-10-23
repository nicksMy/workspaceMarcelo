// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe06
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variaveis
            double primeiroValor, segundoValor;

            // Atribuição e chamada de função
            primeiroValor = leValor("Digite o primeiro valor númerico: ");
            segundoValor = leValor("Digite o segundo valor númerico: ");

            // Chamada de procedimento
            confereValor(primeiroValor, segundoValor);

        }
        // Criação de função 
        static public double leValor (string frase) {
            // Declaração de variavel
            double valorLido;

            // Exibição de linha para o usuario
            Console.WriteLine(frase);

            // Conversão e armazenamento de dado de entrada
            valorLido = double.Parse(Console.ReadLine());

            // Retorno de dado da variavel
            return valorLido;
        }

        // Criação de proocedimento
        static public void confereValor (double primeiroValor, double segundoValor) {
            // Declaração de variavel
            double total;
            int i;

            // Utilização de estrutura de controle
            if (segundoValor == 0) {
                // Utilização de estrutura de repetição
                for (i = 0; i < 1000; i++) {
                    // Atribuição e chamada de função
                    segundoValor = leValor("VALOR INVÁLIDO\nDigite novamente o segundo valor");

                    // Utilização de estrutura de controle
                    if (segundoValor != 0) {
                        // Quedra do laço de repetição
                        break;
                    }
                }                
            // Atribuição de expressão
            total = (primeiroValor / segundoValor);

            // Exibição de linha para o usuario
            Console.WriteLine($"Seus valores são: {primeiroValor} e {segundoValor}\nValor da divisão: {total}");
            }
        }
    }
}
