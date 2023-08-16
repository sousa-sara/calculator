using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); //"chamar o método 'Soma' abaixo

        }
        static void Menu()

        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine()); //de novo usar o conversor pois o res é uma string e o short um número
                                                         //chamar qual método usando Switch Case

            switch (res) //foi melhor, neste caso, utilizar switch case em vez de if/else pela quantidade de casos.
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; //sair do sistema (environment é ambiente) e no parâmetro tem o 0 porque significa 'saiu com sucesso')
                default: Menu(); break; //vai recarregar a tela e o usuário vai passar pelo processo novamente
            }

        }
        static void Soma()
        {
            Console.Clear(); //efeito de limpar a tela antes do dotnet run automaticamente

            Console.WriteLine("Primero valor: "); //mensagem pro usuário
            float v1 = float.Parse(Console.ReadLine()); //armazenar o valor que o usuário digitar em uma variável (v1) do tipo float(intermediário)
                                                        //quando coloca só 'Console.ReadLine();' aparece que ele só 
                                                        //retorna o tipo 'string', aí utilizamos o tipo com .Parse para a conversão
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é " + (v1 + v2)); //para somar as variáveis na concatenção, é preciso colocar entre parênteses para entender que é uma operação aritmética
            Console.ReadKey();
            Menu(); //chamar 'função dentro de função'. neste caso, para que não finalize a execução e o menu reapareça depois de mostrar o resultado
            // Console.WriteLine($"O resultado da soma é {resultado}"); //interpolação: também é possível, usar $ antes das aspas e colocar a variável entre chaves dentro da string.
            // Console.WriteLine($"O resultado da soma é {v1 + v2}"); //dá para colocar a soma das variáveis dentro da interpolação
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey(); //não sair da tela quando executa
            Menu(); //chamar 'função dentro de função'. neste caso, para que não finalize a execução e o menu reapareça depois de mostrar o resultado
        }
        static void Divisao()

        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu(); //chamar 'função dentro de função'. neste caso, para que não finalize a execução e o menu reapareça depois de mostrar o resultado
        }

        static void Multiplicacao()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
            Console.ReadKey();
            Menu(); //chamar 'função dentro de função'. neste caso, para que não finalize a execução e o menu reapareça depois de mostrar o resultado

            /*Ao executar o dotnet run:

            “O que deseja fazer?

            1 - Soma
            2 - Subtração
            3 - Divisão
            4 - Multiplicação
            5 - Sair”

            “Selecione uma opção:” 
            Ex.: 1

            Enter

            “Primeiro valor:”
            Ex.: 5

            Enter

            “Segundo valor:”
            Ex.: 5

            “O resultado da soma é 10”

            ESC retorna ao menu

            */
        }
    }
}