using System;

namespace exe02
{
    class Program
    {
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

        public static String leUltimoNome (string frase) {
            // declaração de variavel
            String ultimoNome;
            Console.WriteLine(frase);

            // atribuição e conversão de entrada
            ultimoNome = Convert.ToString(Console.ReadLine());

            // retorno de valor
            return ultimoNome;
        }

        public static DateTime leDataNascimento (string frase) {
            // declaração de variavel
            DateTime dataNascimento;
            Console.WriteLine(frase);

            // atribuição e conversão de entrada
            dataNascimento = DateTime.Parse(Console.ReadLine());

            // retorno de valor
            return dataNascimento;
        }

        public static void exibeNomeData (string nomeData) {
            Console.WriteLine($"Seu último nome e sua data de nascimento são: {nomeData}");
        }
    }
}
