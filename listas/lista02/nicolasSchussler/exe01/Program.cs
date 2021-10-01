// Bruno Napoleão A. M. & Nicolas Schüssler G. - 01/10/21
using System;

namespace exe01
{
    class Program
    {   
        // Ponto de entrada
        static void Main(string[] args){
            // Declaração de variavel
            int idade;

            // Atribuição e chamada de funçao
            idade = leIdade("Digite sua idade:");

            // Chamada de procedimento
            verificaIdade(idade);
        }
        // Criação de função
        static public int leIdade (string frase) {
            // Declaração de variavel
            int idadeLida;

            // Escrever linha
            Console.WriteLine(frase);

            // Conversão e armazenamento do dado lido
            idadeLida = int.Parse(Console.ReadLine());

            // Retornar valor
            return idadeLida;
        }
        // Criação de procedimento
        static public void verificaIdade (int idadeVerifica) {
            // Se idade for menor que 18 = menor de idade
            if (idadeVerifica < 18) {
                // Escrever linha
                Console.WriteLine("Você é menor de idade");
            // Mas se idade for maior ou igual a 18 e menor que 65 = maior de idade
            } else if (idadeVerifica >= 18 && idadeVerifica < 65) {
                // Escrever linha
                Console.WriteLine("Você é maior de idade");
            // Mas se idade for maior ou igual a 65 e menor que 100  = terceira idade
            } else if (idadeVerifica >= 65 && idadeVerifica < 100) {
                // Escrever linha
                Console.WriteLine("Você está na terceira idade");
            // Mas se idade for maior ou igual a 100 e menor que 125 = anciã(o)
            } else if (idadeVerifica >= 100 && idadeVerifica < 125) {
                // Escrever linha
                Console.WriteLine("Você é um(a) anciã(o)");
            // Mas se for diferente das opções acima = errado
            } else {
                // Escrever linha
                Console.WriteLine("Digite sua idade corretamente");
            }
        }
    }
}
