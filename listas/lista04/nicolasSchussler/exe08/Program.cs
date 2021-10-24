// Bruno Napoleão A. M. & Nicolas Schüssler G. - 22/10/21
using System;

namespace exe08
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração de variaveis
            double nota01, nota02, nota03, nota04, nota05, nota06;
            bool continua = true;

            // Utilização de estrutura de controle
             while (continua == true) {
                // Atribuição e chamada de função
                nota01 = leNota("Digite sua nota: ");
                nota02 = leNota("Digite sua nota: ");
                nota03 = leNota("Digite sua nota: ");
                nota04 = leNota("Digite sua nota: ");
                nota05 = leNota("Digite sua nota: ");
                nota06 = leNota("Digite sua nota: ");

                // Chamada de procedimento
                calculaMedia(nota01, nota02, nota03, nota04, nota05, nota06);
                
                // Atribuição e chamada de função
                continua = novoCalculo("NOVO CÁLCULO (S/N)?");
             }
        }
        // Criação de função
        static public bool novoCalculo (string frase) {
            // Declaração de variavel
            string resultado;
            bool continua = false;

            // Escrever linha para usuario
            Console.WriteLine(frase);

            // Conversão e armazenamento de dado de entrada
            resultado = Convert.ToString(Console.ReadLine());

            // Utilização de estrutura de controle
            if (resultado == "S" || resultado == "s") 
                // Atribuição de valor bool
                continua = true;

            // Utilização de estrutura de controle
            if (resultado == "N" || resultado == "n") 
                // Atribuição de valor bool
                continua = false;

            // Retorno de dado 
            return continua;
        }

        // Criação de função
        static public double leNota (string frase) {
            // Declaração de variavel
            double notaLida;

            // Escrever linha para usuario
            Console.WriteLine(frase);

            // Conversão e armazenamento de dado de entrada
            notaLida = double.Parse(Console.ReadLine());

            // Utilização de estrutura de repetição
            while (notaLida < 0 || notaLida > 10) {
                // Escrever linha para usuario
                Console.WriteLine("\nNOTA INVALIDA!\nDigite novamente: ");

                // conversão e armazenamento de dado de entrada
                notaLida = double.Parse(Console.ReadLine());  
            }
            // Retornar dado da variavel
            return notaLida;
        }
        // Criação de procedimento
        static public void calculaMedia (double n01, double n02, double n03, double n04, double n05, double n06) {
            // Declaração de variavel
            double resultado;

            // Atribuição de expressão
            resultado = ((n01 + n02 + n03 + n04 + n05 + n06) / 6);

            // Escrever linha para o usuario
            Console.WriteLine($"\nO resultado da média simples foi: {resultado}");
        }
    }
}