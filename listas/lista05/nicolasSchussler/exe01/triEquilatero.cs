// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class TriEquilatero
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double area;
        private double volume;
        private double perimetro;
        private double altura;
        private double profundidade;

        // comportamento / métodos
        public TriEquilatero (double h, double prof)
        // construtor
        {
            altura = h;
            profundidade = prof;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = Math.Pow(altura, 2) / Math.Sqrt(3);
        }
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = (Math.Pow(altura, 2) / 3) * profundidade;
        }
        public void calculaPerimetro ()
        // procedimento para calcular o perimetro
        {
            perimetro = 3 * (2 * altura) / Math.Sqrt(3);
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