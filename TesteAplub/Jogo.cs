using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAplub
{
    class Jogo
    {
        public int[] arr = new int[] { 1, 2, 3 };
        public int pedra = 1;
        public int papel = 2;
        public int tesoura = 3;
        public int opcaoJogador = 0;
        static Random r = new Random();
        public int opcaoComp = r.Next(1, 4);


        public void inicia()
        {
            /*if (opcaoComp == 4){
            int opcaoComp = r.Next(1, 4);
            }*/

            Console.WriteLine("\nJokenpo");
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
                Console.WriteLine($"Jogo empatado! Você escolheu {opcaoJogador} e o computador escolheu {opcaoComp}!");
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
            else
            {
                Console.WriteLine($"Parametro recebido - {opcaoJogador} | Computador escolheu - {opcaoComp}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
                /* Console.WriteLine("Jogar Novamente? (S/N)");
                 char op = Console.ReadKey().KeyChar;
                 if (op == 's' || op == 'S')
                 {
                     Console.Clear();
                     inicia();
                 }*/
            }

        }
    }
}
