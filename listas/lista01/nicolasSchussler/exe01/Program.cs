// Bruno Napoleão A. M. & Nicolas Schüssler G. - 11/09/21
using System;

namespace exe01
{
    class Program
    {
        // ponto de entrada
        static void Main(string[] args) {
            // declaração de variaveis
            String nome, sobreNome;
            
            // atribuição e chamada de função
            nome = leNomeInteiro("Digite seu nome");
            sobreNome = leNomeInteiro("Digite seu sobrenome");

            // chamada de procedimento
            exibirNomeInteiro($"{nome} {sobreNome}");
        }
        // criação da função
        public static String leNomeInteiro (string frase) {
            
            // declaração de variavel
            String nomeCompleto;

            // escrever linha no console 
            Console.WriteLine(frase);

            // atribuição e conversão de entrada
            nomeCompleto = Convert.ToString(Console.ReadLine());    

            // retorno de valor
            return nomeCompleto;
        }
        // criação de procedimento
        public static void exibirNomeInteiro (string nomeCompleto) {
            // escrever linha no console 
            Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
        }
    }
}
