// Bruno Napoleão A. M. & Nicolas Schüssler G. - 08/10/21
using System;

namespace exe01
{
    class Program
    {
        static void Main(string[] args) {
            double numero;

            numero = leNumero("Digite um número para efetuar tabuada:");

            fazTabuada(numero);
        }

        static public double leNumero (string frase) {
            double numeroLido;

            Console.WriteLine(frase);

            numeroLido = Convert.ToDouble(Console.ReadLine());

            return numeroLido;
        }

        static void fazTabuada (double valorNumero) {
            int i;
            double tabuada;
            
            for (i = 1; i < 11 ; i++) {
                tabuada = valorNumero * i;
                Console.WriteLine($"{valorNumero} * {i} = {tabuada}");
            }
        }
    }
}
