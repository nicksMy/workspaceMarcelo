// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class Trapezio
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double area;
        private double volume;
        private double altura;
        private double valorBaseMaior;
        private double valorBaseMenor;
        private double profundidade;

        // comportamento / métodos
        public Trapezio (double h, double bMaior, double bMenor, double prof)
        // construtor
        {
            altura = h;
            valorBaseMaior = bMaior;
            valorBaseMenor = bMenor;
            profundidade = prof;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = ((valorBaseMaior + valorBaseMenor) * altura) / 2;
        }
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = (((valorBaseMaior + valorBaseMenor) * altura) / 2) * profundidade * (valorBaseMenor + valorBaseMaior) / 2;
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
    }
}