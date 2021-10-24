// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe10
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variavel
            int valorInteiro;

            // Atribuição e chamada de função
            valorInteiro = leValorInteiro("Digite um valor inteiro para efetuar tabuada: \nO NÚMERO DEVE ESTAR ENTRE 1 E 10 ");

            // Chamada de procedimento
            fazTabela(valorInteiro);
        }
        // Criação de função
        static public int leValorInteiro (string frase) {
            // Declaração de variavel
            int valorLido;

            // Exibição de linha para o usuario
            Console.WriteLine(frase);

            // Conversão e armazenamento de dado de entrada
            valorLido = int.Parse(Console.ReadLine());

            // Utilização de estrutura de repetição
            while (valorLido < 1 || valorLido > 10) {
                // Exibição de linha para o usuario
                Console.WriteLine("\nVALOR INVALIDO!\nDigite novamente: ");

                // Conversão e armazenamento de dado de entrada
                valorLido = int.Parse(Console.ReadLine());                
            }
            // Retornar valor
            return valorLido;
        }
        // Criação de procedimento
        static public void fazTabela (int valorInteiro) {
            // Declaração de variavel
            int resultado;

            // Utilização de estrutura de repetição
            for (int i = 1; i < 11; i++) {
                // Atribuição de valor para a expressão
                resultado = (i * valorInteiro);

                // Exibição de linha para o usuario
                Console.WriteLine($"{i} * {valorInteiro} = {resultado}");
            }
        }
    }
}
