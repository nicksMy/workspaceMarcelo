// Bruno Napoleão A. M. & Nicolas Schüssler G. - 01/10/21
using System;

namespace exe03
{
    class Program
    {
        // Ponto de entrada
        static void Main(string[] args) {
            // Declaração das variaveis
            double nota01, nota02, nota03, nota04, nota05, nota06,
                    mediaM1, mediaM2, mediaM3;

            // Atribuição e chamada de função
            nota01 = leNota("Digite a sua primeira nota da M1:");
            nota02 = leNota("Digite a sua segunda nota da M1:");

            nota03 = leNota("Digite a sua primeira nota da M2:");
            nota04 = leNota("Digite a sua segunda nota da M2:");

            nota05 = leNota("Digite a sua primeira nota da M3:");
            nota06 = leNota("Digite a sua segunda nota da M3:");

            mediaM1 = calculaMedia(nota01, nota02);
            mediaM2 = calculaMedia(nota03, nota04);
            mediaM3 = calculaMedia(nota05, nota06);

            // Chamada de procedimento
            mediaFinal(mediaM1, mediaM2, mediaM3);

        }
        // Criação de função
        static public double leNota (string frase) {
            // Declaração da variavel
            double notaLida;

            // Escrever linha
            Console.WriteLine(frase);

            // Converter e armazenar dado
            notaLida = double.Parse(Console.ReadLine());

            // Retornar o valor lido
            return notaLida;
        }
        // Criação de função
        static public double calculaMedia (double n01, double n02) {
            // Declaração da variavel
            double mediaCalculada;
            int peso01 = 4;
            int peso02 = 6;

            // Efetuação do calculo da média
            mediaCalculada = (((n01 * peso01) + (n02 * peso02)) / 10);

            // Retornar resultado do calculo
            return mediaCalculada;
        }
        // Criação do procedimento
        static public void mediaFinal (double m1, double m2, double m3) {
            // Declaração da variavel
            double mediaFinalCalculada;

            // Efetuação do calculo da média final
            mediaFinalCalculada = ((m1 + m2 + m3) / 3);

            // Se media for maior ou igual a 6 você foi aprovado
            if (mediaFinalCalculada >= 6) {
                // Escrever linha
                Console.WriteLine($"Você foi aprovado!\nSua média ficou: {mediaFinalCalculada}");
            // Mas se media for menor que 6 você foi reprovado
            } else if (mediaFinalCalculada < 6) {
                // Escrever linha
                Console.WriteLine($"Você foi reprovado!\nSua média ficou: {mediaFinalCalculada}");
            }
        }
    }
}
