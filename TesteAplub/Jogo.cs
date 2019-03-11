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

        Jogador jog = new Jogador();

        //Função que retorna um int entre 1 e 4 para ser a opção do computador
        static Random r = new Random();
        public int opcaoComp = r.Next(1, 4);

        //Função que inicia o jogo
        public void inicia()
        {

            Console.WriteLine("Jokenpo");
            Console.WriteLine("Escolha a sua jogada!");
            Console.WriteLine("1 - Pedra\n2 - Papel\n3 - Tesoura\n");
            jog.opcaoJogador = Console.Read();

            //Formata a opção do usuário de ASCII para int
            if (jog.opcaoJogador == 49)
            {
                jog.opcaoJogador = 1;
            }

            else if (jog.opcaoJogador == 50)
            {
                jog.opcaoJogador = 2;
            }

            else if (jog.opcaoJogador == 51)
            {
                jog.opcaoJogador = 3;
            }

            //Formata o texto para exibição
            if (jog.opcaoJogador == 1)
            {
                printJog = "pedra";                
            }

            else if (jog.opcaoJogador == 2)
            {
                printJog = "papel";                
            }

            else if (jog.opcaoJogador == 3)
            {
                printJog = "tesoura";
            }

            if(opcaoComp == 1)
            {
                printComp = "pedra";
            }
            else if(opcaoComp == 2)
            {
                printComp = "papel";
            }
            else if (opcaoComp == 3)
            {
                printComp = "tesoura";
            }

            //Empate
            if (jog.opcaoJogador == opcaoComp)
            {
                Console.WriteLine($"Jogo empatado! Você escolheu {printJog} e o computador escolheu {printComp}!");
            }

            //Resultados
            else if (jog.opcaoJogador == 1 && opcaoComp == 3)
            {
                Console.WriteLine($"Jogador Venceu!\nJogador escolheu {printJog} | Computador escolheu {printComp}\nPedra vence de Tesoura!");

            }
            else if (jog.opcaoJogador == 3 && opcaoComp == 1)
            {
                Console.WriteLine($"Computador Venceu!\nJogador escolheu {printJog} | Computador escolheu {printComp}\nPedra vence de Tesoura!");

            }
            else if (jog.opcaoJogador == 2 && opcaoComp == 1)
            {
                Console.WriteLine($"Jogador Venceu!\nJogador escolheu {printJog} | Computador escolheu {printComp}\nPapel vence de Pedra!");

            }
            else if (jog.opcaoJogador == 1 && opcaoComp == 2)
            {
                Console.WriteLine($"Computador Venceu!\nJogador escolheu {printJog} | Computador escolheu {printComp}\nPapel vence de Pedra!");

            }

            else if (jog.opcaoJogador == 3 && opcaoComp == 2)
            {
                Console.WriteLine($"Jogador Venceu!\nJogador escolheu {printJog} | Computador escolheu {printComp}\nTesoura vence de Papel!");

            }
            else if (jog.opcaoJogador == 2 && opcaoComp == 3)
            {
                Console.WriteLine($"Computador Venceu!\nJogador escolheu {printJog} | Computador escolheu {printComp}\nTesoura vence de Papel!");

            }

        }
    }
}
