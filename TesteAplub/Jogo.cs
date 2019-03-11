using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAplub
{
    class Jogo
    {
        public string printJog;
        public string printComp;
        public int opcaoJogador;
        static Random r = new Random();
        public int opcaoComp = r.Next(1, 4);


        public void inicia()
        {
            /*if (opcaoComp == 4){
            int opcaoComp = r.Next(1, 4);
            }*/

            Console.WriteLine("Jokenpo");
            Console.WriteLine("Escolha a sua jogada!");
            Console.WriteLine("1 - Pedra - 2 - Papel - 3 - Tesoura");
            opcaoJogador = Console.Read();

            if (opcaoJogador == 49)
            {
                opcaoJogador = 1;
            }

            else if (opcaoJogador == 50)
            {
                opcaoJogador = 2;
            }

            else if (opcaoJogador == 51)
            {
                opcaoJogador = 3;
            }

            if (opcaoJogador == opcaoComp)
            {
                if(opcaoJogador == 1 || opcaoComp == 1)
                {
                    printJog = "pedra";
                    printComp = "pedra";
                }

                if (opcaoJogador == 2 || opcaoComp == 2)
                {
                    printJog = "papel";
                    printComp = "papel";
                }

                if (opcaoJogador == 3 || opcaoComp == 3)
                {
                    printJog = "tesoura";
                    printComp = "tesoura";
                }
                Console.WriteLine($"Jogo empatado! Você escolheu {printJog} e o computador escolheu {printComp}!");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
                /*Console.WriteLine("Jogar Novamente? (S/N)");
                char op = Console.ReadKey().KeyChar;
                if (op == 's' || op == 'S')
                {
                    Console.Clear();
                    inicia();
                }*/

            }
            else if(opcaoJogador == 1 && opcaoComp == 3)
            {
                Console.WriteLine($"Jogador Venceu!\nPedra vence de Tesoura!\nJogador escolheu a opção {opcaoJogador} | Computador escolheu a opção {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
            else if (opcaoJogador == 3 && opcaoComp == 1)
            {
                Console.WriteLine($"Computador Venceu!\nPedra vence de Tesoura!\nJogador escolheu a opção {opcaoJogador} | Computador escolheu a opção {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
            else if (opcaoJogador == 2 && opcaoComp == 1)
            {
                Console.WriteLine($"Jogador Venceu!\nPapel vence de Pedra!\nJogador escolheu a opção {opcaoJogador} | Computador escolheu a opção {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
            else if (opcaoJogador == 1 && opcaoComp == 2)
            {
                Console.WriteLine($"Computador Venceu!\nPapel vence de Pedra!\nJogador escolheu a opção {opcaoJogador} | Computador escolheu a opção {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }

            else if (opcaoJogador == 3 && opcaoComp == 2)
            {
                Console.WriteLine($"Jogador Venceu!\nTesoura vence de Papel!\nJogador escolheu a opção {opcaoJogador} | Computador escolheu a opção {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
            else if (opcaoJogador == 2 && opcaoComp == 3)
            {
                Console.WriteLine($"Computador Venceu!\nTesoura vence de Papel!\nJogador escolheu a opção {opcaoJogador} | Computador escolheu a opção {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }

        }
    }
}
