﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAplub
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo j = new Jogo();

            j.inicia();

            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
