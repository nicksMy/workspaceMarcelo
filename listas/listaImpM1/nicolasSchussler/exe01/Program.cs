// Bruno Napoleão A. M. & Nicolas Schüssler G. - 10/09/21
using System;

namespace exe01
{
    class Program
    {

        static void Main(string[] args) {
            // declaração de variaveis
            String nome, sobreNome;
            
            // atribuição e chamada de função
            nome = leNomeInteiro("Digite seu nome");
            sobreNome = leNomeInteiro("Digite seu sobrenome");

            // chamada de procedimento
            exibirNomeInteiro($"{nome} {sobreNome}");
        }

        public static String leNomeInteiro (string frase) {
            
            // declaração de variavel
            String nomeCompleto;
            Console.WriteLine(frase);

            // atribuição e conversão de entrada
            nomeCompleto = Convert.ToString(Console.ReadLine());    

            // retorno de valor
            return nomeCompleto;
        }

        public static void exibirNomeInteiro (string nomeCompleto) {
            Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
        }
    }
}
