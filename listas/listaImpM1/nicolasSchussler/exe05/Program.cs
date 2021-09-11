// Bruno Napoleão A. M. & Nicolas Schüssler G. - 11/09/21
using System;

namespace exe05
{
    class Program
    {
        // ponto de entrada
        static void Main(string[] args){
        // declaração de variaveis
        Double lado01, lado02, lado03, valorArea, semiPerimetro;

        // atribuição e chamada de função 
        lado01 = leLado("Digite um lado do triângulo");
        lado02 = leLado("Digite um lado do triângulo");
        lado03 = leLado("Digite um lado do triângulo");

        // atribuição e chamada de função
        semiPerimetro = calculaPerimetro(lado01, lado02, lado03);
        valorArea = calculaArea(lado01, lado02, lado03, semiPerimetro);

        // chama de procedimento
        exibeArea(valorArea);
        }
        // criação de  função
        public static Double leLado (string frase) {
            // escrever linha no console
            Console.WriteLine(frase);

            // retornar valor lido
            return Convert.ToDouble(Console.ReadLine());
        }
        // criação de função privada
        private static Double calculaPerimetro (double lado01, double lado02, double lado03) {
            // declaração de variavel
            Double semiPerimetro;

            // atribuição de equação
            semiPerimetro = ((lado01 + lado02 + lado03) / 2);

            // retornar resultado da equação
            return semiPerimetro;
        }
        // criação de função
        public static Double calculaArea (double lado01, double lado02, double lado03, double semiPerimetro) {
            // declaração de variavel
            Double area;

            // atribuição de equação de heron
            area = Math.Sqrt(semiPerimetro * (semiPerimetro - lado01) * (semiPerimetro - lado02) * (semiPerimetro - lado03));

            // retornar resultado da equação
            return area;
        }
        // criação de procedimento
        public static void exibeArea (double area) {
            // escrever linha no console
            Console.WriteLine($"A área do seu triângulo é: {area}");
        }
    }
}
