// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class Esfera
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double raio;
        private double area;
        private double volume;

        // comportamento / métodos
        public Esfera (double r)
        // construtor
        {
            raio = r;
        }
        public void calculaArea ()
        // procedimento para calcular a area
        {
            area = 4 * Math.PI * Math.Pow(raio, 2);
        }
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = 4 * Math.PI * Math.Pow(raio, 3) / 3;
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