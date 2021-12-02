// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class TriIsosceles
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double area;
        private double volume;
        private double perimetro;
        private double altura;
        private double valorBase;
        private double profundidade;

        // comportamento / métodos
        public TriIsosceles (double h, double b, double prof)
        // construtor
        {
            altura = h;
            valorBase = b;
            profundidade = prof;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = altura * valorBase / 2;
        }
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = ((altura * valorBase) / 2) * profundidade;
        }
        public void calculaPerimetro ()
        // procedimento para calcular o perimetro
        {
            perimetro = 2 * (Math.Sqrt(Math.Pow(altura, 2) + Math.Pow((valorBase / 2), 2) + valorBase));
        }
        public double getArea ()
        // função para retornar o valor da area
        {
            return area;
        }
        public double getVolume ()
        // função para retornar o valor do volume
        {
            return volume;
        }
        public double getPerimetro ()
        // função para retornar o valor do perimetro
        {
            return perimetro;
        }
    }
}