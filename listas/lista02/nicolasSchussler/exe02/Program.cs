// Bruno Napoleão A. M. & Nicolas Schüssler G. - 01/10/21
using System;

namespace exe02
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args){
            // Declaração de variavel
            double numero;

            // Atribuição e chamada de função
            numero = leNumero("Digite um valor númerico:");

            // Chamada de procedimento
            verificaNumero(numero);
        }
        // Criação de função
        static public double leNumero (string frase) {
            // Declaração de variavel
            double numeroLido;

            // Escrever linha
            Console.WriteLine(frase);

            // Conversão e armazenamento do dado lido
            numeroLido = Convert.ToDouble(Console.ReadLine());

            // Retorno do dado de entrada
            return numeroLido;
        }
        // Criação de procedimento
        static void verificaNumero (double numeroVerifica) {
            // Se numero for igual a 5
            if (numeroVerifica == 5) {
                // Escrever linha
                Console.WriteLine($"Seu número é: {numeroVerifica}");
            // Mas se numero for igual a 200
            } else if (numeroVerifica == 200) {
                // Escrever linha
                Console.WriteLine($"Seu número é: {numeroVerifica}");
            // Mas se numero for igual a 400
            } else if (numeroVerifica == 400) {
                // Escrever linha
                Console.WriteLine($"Seu número é: {numeroVerifica}");
            // Mas se numero for maior que ou igual a 500 e menor ou igual a 1000
            } else if (numeroVerifica >= 500 && numeroVerifica <= 1000) {
                // Escrever linha
                Console.WriteLine($"Seu número está entre 500 e 1000: {numeroVerifica}");
            // Mas se for diferente das opções acima
            } else {
                // Escrever linha
                Console.WriteLine("Está fora dos escopos anteriores");
            }
        }
    }
}
