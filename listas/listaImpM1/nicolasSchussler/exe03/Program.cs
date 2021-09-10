using System;

namespace exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis
            Double num01, num02, num03, valorMedia;

            // atribuição e chamada de função
            num01 = leValores("Digite um valor:");
            num02 = leValores("Digite um valor:");
            num03 = leValores("Digite um valor:");

            // atribuição e chamada de função
            valorMedia = fazerMedia(num01, num02, num03);

            // chamada de função
            exibeMedia(valorMedia);
        }

        public static Double leValores (string frase) {
            // exibição de "frase"
            Console.WriteLine(frase);

            // retornar valor Double
            return Convert.ToDouble(Console.ReadLine());
        }

        public static Double fazerMedia (double valor01, double valor02, double valor03) {
            // declaração de variavel
            Double media;

            // calculo da média
            media = ((valor01 + valor02 + valor03) / 3);

            // retorno do valor da média
            return media;
        }

        public static void exibeMedia (double resultadoMedia) {
            Console.WriteLine($"Sua média é: {resultadoMedia}");
        }
    }
}
