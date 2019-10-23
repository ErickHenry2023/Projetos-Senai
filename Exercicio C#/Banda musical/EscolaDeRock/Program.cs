using System;

namespace EscolaDeRock
{

enum FormacaoEnum : int
{
    TRIO = 3,
    QUARTETO
};


enum FormacaoEnum : int
{
    BAIXO, 
    BATERIA,
    CONTRABAIXO,
    GUITARRA,
    TECLADO,
    TAMBORES,
    VIOLÃO
};



















    class Program
    {
        static void Main(string[] args)
        {
            string[] intensMenuPrincipal = Enum.GetName(typeof(FormacaoEnum));          /*Enum estrutura de dados = cria vector */
            string[] intensMenuCategoria = Enum.GetName(typeof());

            var opcaoesFormacao = new List<string>()        /*var genericoo de dados (colacar sting ela vai ser string) */
            {
                "       -0                      ",
                "       -1                  "
            };

            int opcaoesFormacaoSelecionada = 0;
            string menuBar = "=============================";

            do 
            {
                bool opcaoesEscolhida = false;
                do
                {
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("  Seja bem-vind@!     ");
                    System.Console.WriteLine("  Escolha uma formação     ");
                    Console.ReadLine();
                    System.Console.WriteLine(menuBar);

                for(int i = 0; i< opcaoesFormacao.Count; i++)
                {
                    string titulo = intensMenuPrincipal[i];
                    if(opcaoesFormacaoSelecionada ==i)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        System.Console.WriteLine(opcaoesFormacao[opcaoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                        Console.ResetColor();
                    }
                    else
                    {
                        System.Console.WriteLine(opcaoesFormacao[i].Replace(i.ToString(), titulo));
                    }
                }
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        opcaoesFormacaoSelecionada = opcaoesFormacaoSelecionada == 0 ? opcaoesFormacaoSelecionada : -- opcaoesFormacaoSelecionada;  /*operação ternaria c# */
                        break;
                    case ConsoleKey.DownArrow:
                        opcaoesFormacaoSelecionada = opcaoesFormacaoSelecionada == opcaoesFormacao.Count - 1 ? opcaoesFormacaoSelecionada : ++opcaoesFormacaoSelecionada;
                        break;
                    case ConsoleKey.Enter: 
                        formacaoEscolhida = true;
                        break;
                }

                } while (false);

            } while (!querSair);
        }
    }
}

