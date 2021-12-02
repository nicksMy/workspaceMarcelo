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
            double altura = 0;
            double raio = 0;
            double valorBase = 0;
            double valorBaseMaior = 0;
            double valorBaseMenor = 0;
            double diagonalMenor = 0;
            double diagonalMaior = 0;
            double profundidade = 0;

            // calculos de acordo com a opção
            switch (escolha)
            {
                // cilindro                
                case 1:
                    // inicio do escopo case 1

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a altura do cilindro");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n> Digite o raio do cilindro");
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
                    // inicio do escopo case 2

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite o raio do circulo");
                    Double.TryParse(Console.ReadLine(), out raio);

                    // cria o objeto circulo como tipo Circulo
                    Circulo circulo = new Circulo (raio);

                    // acessa os métodos públicos para calcular
                    circulo.calculaArea();
                    circulo.calculaPerimetro();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Circulo: " + circulo.getArea() + " m²");
                    Console.WriteLine("Perimetro do seu Circulo: " + circulo.getPerimetro() + " m");

                    // quebra a execução do bloco
                    break;

                // elipse
                case 3:
                    // inicio do escopo case 3
                    // mensagem para o usuario inserir os dados necessarios
                    // cria o objeto elipse como tipo Elipse
                    // acessa os métodos públicos para calcular
                    // acessa os valores privados e retorna para o usuario 
                    // quebra a execução do bloco
                    break;

                // esfera
                case 4:
                    // inicio do escopo case 4

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite o raio da Esfera");
                    Double.TryParse(Console.ReadLine(), out raio);

                    // cria o objeto esfera como tipo Esfera
                    Esfera esfera = new Esfera (raio);

                    // acessa os métodos públicos para calcular
                    esfera.calculaArea(); 
                    esfera.calculaVolume();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea da sua Esfera: " + esfera.getArea() + " m²");
                    Console.WriteLine("Volume da sua Esfera: " + esfera.getVolume() + " m³");

                    // quebra a execução do bloco                           
                    break;

                // losango
                case 5:
                    // inicio do escopo case 5

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a diagonal menor do Losango");
                    Double.TryParse(Console.ReadLine(), out diagonalMenor);

                    Console.WriteLine("\n> Digite a diagonal maior do Losango" );
                    Double.TryParse(Console.ReadLine(), out diagonalMaior);

                    Console.WriteLine("\n> Digite a profundidade do Losango");
                    Double.TryParse(Console.ReadLine(), out profundidade);

                    // cria o objeto losango como tipo Losango
                    Losango losango = new Losango (diagonalMenor, diagonalMaior, profundidade);

                    // acessa os métodos públicos para calcular
                    losango.calculaArea();
                    losango.calculaVolume();
                    losango.calculaPerimetroBase();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Losango: " + losango.getArea() + " m²");
                    Console.WriteLine("Volume do seu Losango: " + losango.getVolume() + " m³");
                    Console.WriteLine("Perimetro da base do seu Losango: " + losango.getPerimetroBase() + " m");

                    // quebra a execução do bloco       
                    break;

                // paralelogramo
                case 6:
                    // inicio do escopo case 6

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a altura do seu Paralelogramo: ");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n> Digite a base do seu Paralelogramo: ");
                    Double.TryParse(Console.ReadLine(), out valorBase);

                    Console.WriteLine("\n> Digite a profundidade do seu Paralelogramo: ");
                    Double.TryParse(Console.ReadLine(), out profundidade);

                    // cria o objeto paralelogramo como tipo Paralelogramo
                    Paralelogramo paralelogramo = new Paralelogramo (altura, valorBase, profundidade);

                    // acessa os métodos públicos para calcular
                    paralelogramo.calculaArea();
                    paralelogramo.calculaVolume();
                    paralelogramo.calculaPerimetro();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Paralelogramo: " + paralelogramo.getArea() + " m²");
                    Console.WriteLine("Volume do seu Paralelogramo: " + paralelogramo.getVolume() + " m³");
                    Console.WriteLine("Perimetro do seu Paralelogramo: " + paralelogramo.getPerimetro() + " m");                    

                    // quebra a execução do bloco       
                    break;

                // quadrado
                case 7:
                    // inicio do escopo case 7

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a altura do seu Quadrado: ");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n> Digite a base do seu Quadrado: ");
                    Double.TryParse(Console.ReadLine(), out valorBase);

                    Console.WriteLine("\n> Digite a profundidade do seu Quadrado: ");
                    Double.TryParse(Console.ReadLine(), out profundidade);

                    // cria o objeto quadrado como tipo Quadrado
                    Quadrado quadrado = new Quadrado (altura, valorBase, profundidade);

                    // acessa os métodos públicos para calcular
                    quadrado.calculaArea();
                    quadrado.calculaVolume();
                    quadrado.calculaPerimetro();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Quadrado: " + quadrado.getArea() + " m²");
                    Console.WriteLine("Volume do seu Quadrado: " + quadrado.getVolume() + " m³");
                    Console.WriteLine("Perimetro do seu Quadrado: " + quadrado.getPerimetro() + " m");

                    // quebra a execução do bloco       
                    break;

                // retangulo
                case 8:
                    // inicio do escopo case 8

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a altura do seu Retângulo: ");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n> Digite a base do seu Retângulo: ");
                    Double.TryParse(Console.ReadLine(), out valorBase);

                    Console.WriteLine("\n> Digite a profundidade do seu Retângulo: ");
                    Double.TryParse(Console.ReadLine(), out profundidade);
                    // cria o objeto retangulo como tipo Retangulo
                    Retangulo retangulo = new Retangulo (altura, valorBase, profundidade);

                    // acessa os métodos públicos para calcular
                    retangulo.calculaArea();
                    retangulo.calculaVolume();
                    retangulo.calculaPerimetro();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Retângulo: " + retangulo.getArea() + " m²");
                    Console.WriteLine("Volume do seu Retângulo: " + retangulo.getVolume() + " m³");
                    Console.WriteLine("Perimetro do seu Retângulo: " + retangulo.getPerimetro() + " m");

                    // quebra a execução do bloco       
                    break;

                // trapezio
                case 9:
                    // inicio do escopo case 9
    
                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a altura do seu Trapézio: ");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n> Digite a base maior do seu Trapézio: ");
                    Double.TryParse(Console.ReadLine(), out valorBaseMaior);

                    Console.WriteLine("\n> Digite a base menor do seu Trapézio: ");
                    Double.TryParse(Console.ReadLine(), out valorBaseMenor);

                    Console.WriteLine("\n> Digite a profundidade do seu Trapézio: ");
                    Double.TryParse(Console.ReadLine(), out profundidade);

                    // cria o objeto trapezio como tipo Trapezio
                    Trapezio trapezio = new Trapezio (altura, valorBaseMaior, valorBaseMenor, profundidade);

                    // acessa os métodos públicos para calcular
                    trapezio.calculaArea();
                    trapezio.calculaVolume();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Trapézio: " + trapezio.getArea() + " m²");
                    Console.WriteLine("Volume do seu Trapézio: " + trapezio.getVolume() + " m³");

                    // quebra a execução do bloco       
                    break;

                // triangulo equilatero
                case 10:
                    // inicio do escopo case 10

                    // mensagem para o usuario inserir os dados necessarios
                    Console.WriteLine("\n> Digite a altura do seu Triângulo Equilátero: ");
                    Double.TryParse(Console.ReadLine(), out altura);

                    Console.WriteLine("\n> Digite a profundidade do seu Triângulo Equilátero: ");
                    Double.TryParse(Console.ReadLine(), out profundidade);

                    // cria o objeto triEquilatero como tipo TriEquilatero
                    TriEquilatero triEquilatero = new TriEquilatero (altura, profundidade);

                    // acessa os métodos públicos para calcular
                    triEquilatero.calculaArea();
                    triEquilatero.calculaVolume();
                    triEquilatero.calculaPerimetro();

                    // acessa os valores privados e retorna para o usuario
                    Console.WriteLine("\nÁrea do seu Triângulo Equilátero: " + triEquilatero.getArea() + " m²");
                    Console.WriteLine("Volume do seu Triângulo Equilátero: " + triEquilatero.getVolume() + " m³");
                    Console.WriteLine("Perimetro do seu Triângulo Equilátero: " + triEquilatero.getPerimetro() + " m");

                    // quebra a execução do bloco       
                    break;

                // triangulo isosceles
                case 11:
                    // inicio do escopo case 11

                    // mensagem para o usuario inserir os dados necessarios

                    // cria o objeto triIsosceles como tipo TriIsosceles

                    // acessa os métodos públicos para calcular

                    // acessa os valores privados e retorna para o usuario

                    // quebra a execução do bloco       
                    break;

                // triangulo retangulo
                case 12:
                    // inicio do escopo case 12

                    // mensagem para o usuario inserir os dados necessarios

                    // cria o objeto triRetangulo como tipo TriRetangulo

                    // acessa os métodos públicos para calcular

                    // acessa os valores privados e retorna para o usuario

                    // quebra a execução do bloco       
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

                if (numOpcao >= 1 && numOpcao <= 12)
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
