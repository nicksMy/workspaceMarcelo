// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace exe01
// inicio de escopo do namespace
{
    class Program
    // inicio de escopo da classe Program   
    {
        static void Main(string[] args) 
        // ponto de entrada do programa
        {
            // chamada do procedimento para exibir as opções
            menu();

            // armazena o valor retornado da função "leOpcao"
            int escolha = leOpcao();

            // calculos de acordo com a opção
            switch (escolha)
            {
                // cilindro                
                case 1:
                    // inicio do escopo case 1
                    double altura = 0;
                    double raio = 0;

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n>Digite a altura do cilindro");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n>Digite o raio do cilindro");
                    Double.TryParse(Console.ReadLine(), out raio);

                    // cria o objeto cilindro como tipo Cilindro
                    Cilindro cilindro = new Cilindro (altura, raio);
                    
                    // acessa os métodos públicos para calcular 
                    cilindro.calculaAreaBase();
                    cilindro.calculaAreaLateral();
                    cilindro.calculaAreaTotal();
                    cilindro.calculaVolume();
                    cilindro.calculaPerimetro();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea da base do seu Cilindro: " + cilindro.getAreaBase() + " m²");
                    Console.WriteLine("Área lateral do seu Cilindro: " + cilindro.getAreaLateral() + " m²");
                    Console.WriteLine("Área total do seu Cilindro: " + cilindro.getAreaTotal() + " m²");
                    Console.WriteLine("Volume do seu Cilindro: " + cilindro.getVolume() + " m³");
                    Console.WriteLine("Perimetro do seu Cilindro: " + cilindro.getPerimetro() + " m");

                    // quebra a execução do bloco   
                    break;

                // circulo
                case 2:
                    break;

                // elipse
                case 3:
                    break;

                // esfera
                case 4:
                    break;

                // losango
                case 5:
                    break;

                // paralelogramo
                case 6:
                    break;

                // quadrado
                case 7:
                    break;

                // retangulo
                case 8:
                    break;

                // trapezio
                case 9:
                    break;

                // triangulo equilatero
                case 10:
                    break;

                // triangulo isosceles
                case 11:
                    break;

                // triangulo retangulo
                case 12:
                    break;
            }
        }

        static void menu()
        // procedimento para exibir opções de calculos e seus números correspondentes

        {
            // mostra ínicio do programa
            Console.WriteLine("> Você está rodando: \n> Calculadora Geométrica");

            // mostra opções de calculo disponiveis no programa
            // utilizando a função para organizar
            Console.WriteLine("\n|----------------------OPÇÕES DE CALCULOS----------------------|\n");
            
            Console.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20}", "1) Cilindro", "2) Círculo", "3) Elipse"));

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20}", "4) Esfera", "5) Losango", "6) Paralelogramo"));

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20}", "7) Quadrado", "8) Retângulo", "9) Trapézio"));

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20}", "10) Tri. Equilatero", "11) Tri. Isosceles", "12) Tri. Retângulo"));
        }

        static int leOpcao()
        // função para efetuar a leitura, armazenamento e conversão do valor de entrada
        {
            // armazena valor do tipo de calculo
            int numOpcao = 0;

            // para verificar e controlar o loop do menu
            bool continua = true;

            do
            // inicio de escopo do laço de repetição
            {
                // para armazenar a entrada do teclado
                string numEscolhido;

                // exibe mensagem para o usuario
                Console.WriteLine("\n> Efetue sua escolha:");

                numEscolhido = Console.ReadLine();

                // tenta efetuar a conversão de entrada do teclado
                // caso consiga guarda na variavel "numOpcao"
                // caso não consiga "numOpcao" não muda de valor
                Int32.TryParse(numEscolhido, out numOpcao);

                if (numOpcao >= 1 && numOpcao <= 1)
                // debug para os calculos já implementados
                {
                    // caso verdade altera para false
                    // quebrando o laço de repetição
                    continua = false;
                }   

                else
                {
                    // caso falso limpa o terminal
                    Console.Clear();

                    // exibe mensagem de erro para o usuario
                    Console.WriteLine("Opção invalida!\nTente novamente outra opção\n");

                    // exbie novamente as opções válidas
                    menu();
                }
            } while(continua);
            // caso "continua" seja false, sai do laço de repetição
            // caso "continua" seja true, continua o laço de repetição

            // quando sair do laço retornar valor de "numOpcao"
            return numOpcao;
        }
    }
}
