// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class Circulo
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double raio;
        private double area;
        private double perimetro;

        // comportamento / métodos
        public Circulo (double r)
        // construtor
        {
            raio = r;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = Math.PI * Math.Pow(raio, 2);
        }
        public void calculaPerimetro ()
        // procedimento para calcular o perimetro
        {
            perimetro = 2 * Math.PI * raio;
        }
        public double getArea ()
        // função para retornar o valor da area
        {
            return area;
        }
        public double getPerimetro ()
        // função para retornar o valor do perimetro
        {
            return perimetro;
        }
    }
}