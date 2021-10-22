// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe02
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variaveis 
            string produto;
            int quantidade;
   
            // Escrever tabela de produtos
            Console.WriteLine("\nTABELA DE PREÇOS");
            Console.WriteLine("ABCD    R$100");
            Console.WriteLine("XYPK    R$200");
            Console.WriteLine("KLMP    R$400");
            Console.WriteLine("QRST    R$1000\n");

            /*
            *
            * TORNAR UPPER CASE NO ARMAZENAMENTO
            *
            */

            // Atribuição e chamada de função
            produto = leProduto("Digite o código do produto: ");
            quantidade = leQuantidade("Digite a quantidade do produto:");

            // Chamada de procedimento
            calculaPreco(produto, quantidade);
        }
        // Criação de função
        static public string leProduto (string frase) {
            // Declaração de variavel
            string codigoLido;

            // Escrever linha para usuario
            Console.WriteLine(frase);

            // Converter e armzenar entrada de dado
            codigoLido = Convert.ToString(Console.ReadLine());

            // Retornar o valor lido
            return codigoLido;
        }
        // Criação de função
        static public int leQuantidade (string frase) {
            // Declaração de variavel
            int valorLido;

            // Escrever linha para usuario
            Console.WriteLine(frase);

            // Converter e armzenar entrada de dado
            valorLido = int.Parse(Console.ReadLine());

            // Retornar o valor lido
            return valorLido;
        }
        // Criação de procedimento
        static public void calculaPreco (string produto, int quantidade) {
            // Declração de variavel
            int preco, total;

            // Utilização de estrutura de controle
            if (produto == "ABCD") {
                // Atribuição de valor
                preco = 100;

                // Atribuição de expressão
                total = preco * quantidade;
                
                // Escrever linha para usuario
                Console.WriteLine($"O valor total fica: R${total}");
            // Utilização de estrutura de controle
            } else if (produto == "XYPK") {
                // Atribuição de valor
                preco = 200;

                // Atribuição de expressão
                total = preco * quantidade;

                // Escrever linha para usuario
                Console.WriteLine($"O valor total fica: R${total}");
            // Utilização de estrutura de controle
            } else if (produto == "KLMP") {
                // Atribuição de valor
                preco = 400;

                // Atribuição de expressão
                total = preco * quantidade;

                // Escrever linha para usuario
                Console.WriteLine($"O valor total fica: R${total}");
            // Utilização de estrutura de controle
            } else if (produto == "QRST") {
                // Atribuição de valor
                preco = 1000;

                // Atribuição de expressão
                total = preco * quantidade;
                
                // Escrever linha para usuario
                Console.WriteLine($"O valor total fica: R${total}");
            // Utilização de estrutura de controle
            } else {
                // Escrever linha para usuario
                Console.WriteLine("Digite um código de produto valido.");
            }
        }
    }
}
