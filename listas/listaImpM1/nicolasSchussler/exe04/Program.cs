// Bruno Napoleão A. M. & Nicolas Schüssler G. - 11/09/21
using System;

namespace exe04
{
    class Program
    {   
        // ponto de entrada
        static void Main(string[] args) {
            // declaração das variaveis
            Double nota01, nota02, nota03, media;
            Double peso01, peso02, peso03;

            // atribuição e chamada de função
            nota01 = leNota("Digite sua nota");
            peso01 = lePeso("Digite o peso da nota");

            nota02 = leNota("Digite sua nota");
            peso02 = lePeso("Digite o peso da nota");

            nota03 = leNota("Digite sua nota");
            peso03 = lePeso("Digite o peso da nota");

            media = calculaMedia(nota01, nota02, nota03, peso01, peso02, peso03);

            // chamada de procedimento
            mostraMedia(media);
        }
        // criaçao de função
        public static Double leNota (string frase) {
            // escrever linha no console
            Console.WriteLine(frase);

            // retornar valor lido
            return Convert.ToDouble(Console.ReadLine());
        }
        // criação de função
        public static Double lePeso (string frase) {
            // escrever linha no console
            Console.WriteLine(frase);

            // retornar valor lido
            return Convert.ToDouble(Console.ReadLine());
        }
        // criação de função
        public static Double calculaMedia (double n01, double n02, double n03, double p01, double p02, double p03) {
            // declaração de variaveis
            Double somaPeso, mediaPonderada;

            // atribuição de equação
            somaPeso = (p01 + p02 + p03);
            mediaPonderada = (((n01 * p01) + (n02 * p02) + (n03 * p03)) / somaPeso);

            // retornar valor da equação
            return mediaPonderada;
        }
        // criação de procedimento
        public static void mostraMedia (double valorMedia) {
            // escrever linha no console
            Console.WriteLine($"O valor da sua média ponderada é: {valorMedia}");
        }
    }
}
