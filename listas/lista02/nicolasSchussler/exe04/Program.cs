// Bruno Napoleão A. M. & Nicolas Schüssler G. - 01/10/21
using System;

namespace exe04
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração da variavel
            int idade;

            // Atribuição e chamada de função
            idade = leIdade("Digite sua idade:");

            // Chamda de procedimento
            identificaCategoria(idade);
        }
        // Criaçõa de função
        static public int leIdade (string frase) {
            // Declaração da variavel
            int idadeLida;

            // Escrever linha
            Console.WriteLine(frase);

            // Conversão e armazenamento do valor de entrada
            idadeLida = int.Parse(Console.ReadLine());

            // Retorno do dado
            return idadeLida;
        }
        // Criação de função
        static public void identificaCategoria (int valorIdade) {
            // Se idade for maior ou igual a 5 e menor ou igual a 7
            if (valorIdade >= 5 && valorIdade <= 7) {
                // Escrever linha
                Console.WriteLine($"Sua idade é: {valorIdade}\nCategoria I - 5-7 anos");
            // Mas se idade for maior ou igual a 8 e menor ou igual a 10
            } else if (valorIdade >= 8 && valorIdade <= 10) {
                // Escrever linha
                Console.WriteLine($"Sua idade é: {valorIdade}\nCategoria II - 8-10 anos");
            // Mas se idade for maior ou igual a 11 e menor ou igual a 13
            } else if (valorIdade >= 11 && valorIdade <= 13) {
                // Escrever linha
                Console.WriteLine($"Sua idade é: {valorIdade}\nCategoria III - 11-13 anos");
            // Mas se idade for maior ou igual a 14 e menor ou igual a 17
            } else if (valorIdade >= 14 && valorIdade <= 17) {
                // Escrever linha
                Console.WriteLine($"Sua idade é: {valorIdade}\nCategoria IV - 14-17 anos");
            // Mas se idade for maior ou igual a 18
            } else if (valorIdade >= 18) {
                // Escrever linha
                Console.WriteLine($"Sua idade é: {valorIdade}\nCategoria V - 18 ou + anos");
            }
        }
    }
}
