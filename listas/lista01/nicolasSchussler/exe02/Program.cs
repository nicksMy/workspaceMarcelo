// Bruno Napoleão A. M. & Nicolas Schüssler G. - 11/09/21
using System;

namespace exe02
{
    class Program
    {
        // ponto de entrada
        static void Main(string[] args)
        {
            // declaração de variaveis
            String nome;
            DateTime data;

            // atribuição e chamada de função
            nome = leUltimoNome("Digite seu último nome");
            data = leDataNascimento("Digite sua data de nascimento no padrão: DD/MM/AAAA");

            // chamada de procedimento
            exibeNomeData($"{nome} {data}");
        }
        // criação da função
        public static String leUltimoNome (string frase) {
            // declaração de variavel
            String ultimoNome;
            
            // escrever linha no console
            Console.WriteLine(frase);

            // atribuição e conversão de entrada
            ultimoNome = Convert.ToString(Console.ReadLine());

            // retorno de valor
            return ultimoNome;
        }
        // criação da função
        public static DateTime leDataNascimento (string frase) {
            // declaração de variavel
            DateTime dataNascimento;

            // escrever linha no console
            Console.WriteLine(frase);

            // atribuição e conversão de entrada
            dataNascimento = DateTime.Parse(Console.ReadLine());

            // retorno de valor
            return dataNascimento;
        }
        // criação de procedimento
        public static void exibeNomeData (string nomeData) {
            // escrever linha no console
            Console.WriteLine($"Seu último nome e sua data de nascimento é: {nomeData}");
        }
    }
}
