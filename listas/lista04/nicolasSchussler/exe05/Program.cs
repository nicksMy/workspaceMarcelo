// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe05
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args ){
            // Declaração de variavel
            double num01, num02, num03;

            // Atribuição e chamada de função
            num01 = leValor("Digite seu primeiro valor númerico: ");
            num02 = leValor("Digite seu segundo valor númerico: ");
            num03 = leValor("Digite seu terceiro valor númerico: ");

            // Chamada de procedimento
            organizaNumeros(num01, num02, num03);

        }
        // Criação de função
        static public double leValor (string frase) {
            // Declaração de variavel
            double valorLido;

            // Escrever linha para usuario
            Console.WriteLine(frase);

            // Conversaõ e armazenamento de dado de entrada
            valorLido = double.Parse(Console.ReadLine());

            // Retornar valor de variavel
            return valorLido;
        }
        // Criação de procedimento
        static public void exibeOrdem (double menor, double medio, double maior) {

            // Escrever linha para usuario
            Console.WriteLine($"{menor} {medio} {maior}");
        }
        // Criação de procedimento
        static public void organizaNumeros (double num01, double num02, double num03) {
            // Declaração de variavel
            double menor, medio, maior;

            // Utilização de estrutura de controle
            if (num01 >= num02 && num01 >= num03) {

                // Atribuição de valor a variavel
                maior = num01;

                // Utilização de estrutura de controle
                if (num02 >= num03) {
                    
                    // Atribuição de valor a variavel
                    medio = num02;
                    menor = num03;     

                    // Chamada de procedimento
                    exibeOrdem(menor, medio, maior);               

                // Utilização de estrutura de controle
                } else {

                // Atribuição de valor a variavel
                menor = num02;
                medio = num03;
                maior = num01;

                // Chamada de procedimento
                exibeOrdem(menor, medio, maior);
                }
            }
            // Utilização de estrutura de controle
            if (num02 >= num01 && num02 >= num03) {
                
                // Atribuição de valor a variavel
                maior = num02;

                // Utilização de estrutura de controle
                if (num01 >= num03) {

                    // Atribuição de valor a variavel
                    medio = num01;
                    menor = num03;

                // Chamada de procedimento
                exibeOrdem(menor, medio, maior);

                // Utilização de estrutura de controle
                } else {

                    // Atribuição de valor a variavel
                    menor = num01;
                    medio = num03;
                    maior = num02;

                // Chamada de procedimento
                exibeOrdem(menor, medio, maior);
                
                }
            }
            // Utilização de estrutura de controle
            if (num03 >= num01 && num03 >= num02) {
                
                // Atribuição de valor a variavel
                maior = num03;

                // Utilização de estrutura de controle
                if (num01 >= num02) {
                    
                    // Atribuição de valor a variavel
                    medio = num01;
                    menor = num02;

                // Chamada de procedimento
                exibeOrdem(menor, medio, maior);

                // Utilização de estrutura de controle
                } else {

                    // Atribuição de valor a variavel
                    menor = num01;
                    medio = num02;
                    maior = num03;

                    // Chamada de procedimento
                    exibeOrdem(menor, medio, maior);
                    
                }
            }
        }
    }
}