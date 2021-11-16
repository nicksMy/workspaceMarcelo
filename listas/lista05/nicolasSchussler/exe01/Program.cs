// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;

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

            switch (escolha)
            // calculos de acordo com a opção
            {
                // pirâmide
                case 1:
                    break;

                // cone
                case 2:
                    break;

                // cilindro
                case 3:
                    break;

                // prisma
                case 4:
                    break;

                // cubo
                case 5:
                    break;

                // esfera
                case 6:
                    break;
            }
        }

        static void menu()
        // procedimento para exibir opções de calculos e seus números correspondentes

        {
            // mostra ínicio do programa
            Console.WriteLine("> Você está rodando: \n> Calculadora Geométrica");

            // mostra opções de calculo disponiveis no programa
            Console.WriteLine("\n----OPÇÕES DE CALCULOS---- \n> 1: Pirâmide  > 4: Prísma\n> 2: Cone      > 5: Cubo\n> 3: Cilindro  > 6: Esfera");
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
