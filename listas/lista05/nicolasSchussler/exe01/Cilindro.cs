// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    public class Cilindro
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double altura;
        private double raio;
        private double volume;
        private double areaBase;
        private double areaLateral;
        private double areaTotal;
        private double perimetro;

        // comportamento / métodos
        public Cilindro (double h, double r)
        // construtor
        {
            altura = h;
            raio = r;
            volume = 0;
        }
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = Math.PI * Math.Pow(raio, 2) * altura;
        }

        public void calculaAreaBase ()
        // procedimento para calcular a area da base
        {
            areaBase = Math.PI * Math.Pow(raio, 2);
        }

        public void calculaAreaLateral ()
        // procedimento para calcular a area lateral
        {
            areaLateral = 2 * Math.PI * raio * altura;
        }
        public void calculaAreaTotal ()
        // procedimento para calcular a area total
        {
            areaTotal = 2 * Math.PI * raio * (raio + altura);
        }
        public void calculaPerimetro ()
        // procedimento para calcular o perimetro
        {
            perimetro = (2 * Math.PI) * raio;
        }
        public double getAreaBase ()
        // função para retornar resultado da area da base
        {
            return areaBase;
        }
        public double getAreaLateral ()
        // função para retornar resultado da area da base
        {
            return areaLateral;
        }
        public double getAreaTotal ()
        // função para retornar resultado da area da base
        {
            return areaTotal;
        }
        public double getVolume ()
        // função para retornar resultado do volume
        {
            return volume;
        }
        public double getPerimetro ()
        // função para retornar resultado do perimetro
        {
            return perimetro;
        }
    }
}