using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {

                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("      Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();

                        Guerreiro guerreiro = CriarGuerreiro();
                        // Guerreiro guerreiro = new Guerreiro();
                        // guerreiro.Nome = "Berserk";
                        // guerreiro.Sobrenome = "Guts";
                        // guerreiro.CidadeNatal = "Tomar";
                        // guerreiro.DataNascimento = DateTime.Parse("18/12/1300");
                        // guerreiro.FerramentaAtaque = "Espada";
                        // guerreiro.FerramentaProtecao = "Escudo";
                        // guerreiro.Forca = 2;
                        // guerreiro.Destreza = 2;
                        // guerreiro.Inteligencia = 4;
                        // guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();       //classe, variavel e//
                        dragao.Nome = "Draco";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - Primeiro Dialogo */
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, Vim-lhe Derotar!");
                        CriarDialogo(dragao.Nome, "Seu Tolo");
                        FinalizarDialogo();
                        // System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, Vim-lhe Derotar!");
                        // System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Seu Tolo");

                        /*FIM - Primeiro Dialogo */


                        /*INICIO - Primeiro Dialogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da Casa {guerreiro.Sobrenome}, ô criatura morfetica");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.Nome}! Da Casa {guerreiro.CidadeNatal}, para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Quem? de onde? bom, que seja... fritar-te-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine("BOOM: tá na hora do show!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte Entre para prosseguir");       /*trocar por FinalizarDialogo(); */
                        Console.ReadLine();

                        /*FIM - Primeiro Dialogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;            //operador ternari "Em forma de pergunta" bool variavel //

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine(" Escolha uma ação");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();
                            
                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa !");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Você errou !"); 
                                    }

                                break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} Simbora filho ");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()} Simbora filho ");
                                    jogadorNaoCorreu = false;
                                break;                                  
                            }    
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte enter para prosseguir");
                        Console.ReadLine();
                        
                        while(guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if ( guerreiroDestrezaTotal < dragaoDestrezaTotal){
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vou te quiemar !");
                                        dragao.Vida -= dragao.Forca;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                    else
                                    {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Você errou !"); 
                                    }

                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte entre para prosseguir");
                                    Console.ReadLine();
                                    
                                    Console.Clear();

                                    System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine(" Escolha uma ação");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();
                            
                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa !");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                    else
                                    {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Você errou !"); 
                                    }

                                break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} Simbora filho ");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()} Simbora filho ");
                                    jogadorNaoCorreu = false;
                                break;                                  
                            } 

                        }
                        
                        if (guerreiro.Vida <=0)
                        {
                            System.Console.WriteLine("Você perdeu!");
                        }
                        if (dragao.Vida <=0)
                        {
                            System.Console.WriteLine("Você venceu!");
                        }                    

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;     //jogador desistiu false, ele digitou 0//
                        System.Console.WriteLine("GAME OVER");      
                        break;
                    default:
                        System.Console.WriteLine("Comando invalido!");
                        break;
                }
            } while (jogadorNaoDesistiu);   //variavel em forma de pergunta


        }
    
        public static void CriarDialogo(string nome, string frase)      /*"assinatura" */
        {
            System.Console.WriteLine($"{nome.ToUpper()}: {frase}");         /*"nome"=guerreio ou dragao/ "frase"=guerriro ou dragao */
        }
        public static void FinalizarDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte Entre para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }
    
        public static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Berserk";
            guerreiro.Sobrenome = "Guts";
            guerreiro.CidadeNatal = "Tomar";
            guerreiro.DataNascimento = DateTime.Parse("18/12/1300");
            guerreiro.FerramentaAtaque = "Espada";
            guerreiro.FerramentaProtecao = "Escudo";
            guerreiro.Forca = 2;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 4;
            guerreiro.Vida = 20;

            return guerreiro;
        }

    }

}
