// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class Paralelogramo
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double altura;
        private double valorBase;
        private double profundidade;
        private double area;
        private double volume;
        private double perimetro;

        // comportamento / métodos
        public Paralelogramo (double h, double b, double prof)
        // construtor
        {
            altura = h;
            valorBase = b;
            profundidade = prof;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = altura * valorBase;
        }
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = altura * valorBase * profundidade;
        }
        public void calculaPerimetro ()
        // procedimento para calcular o perimetro
        {
            perimetro = 2 * altura + 2 * valorBase;
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