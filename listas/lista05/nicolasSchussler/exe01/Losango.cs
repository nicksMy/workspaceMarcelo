// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class Losango
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double diagonalMenor;
        private double diagonalMaior;
        private double profundidade;
        private double area;
        private double volume;
        private double perimetroBase;

        // comportamento / métodos
        public Losango (double dMenor, double dMaior, double prof)
        // construtor
        {
            diagonalMenor = dMenor;
            diagonalMaior = dMaior;
            profundidade = prof;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = (diagonalMenor * diagonalMaior) / 2;
        }
        public void calculaVolume ()
        {
            volume = ((diagonalMenor * diagonalMaior) / 2) * profundidade;
        }
        public void calculaPerimetroBase ()
        // procedimento para calcular o perimetro
        {
            perimetroBase = 4 * diagonalMenor;
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
        public double getPerimetroBase ()
        // função para retornar o valor do perimetro da base
        {
            return perimetroBase;
        }
    }
}