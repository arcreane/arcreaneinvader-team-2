using System;

﻿using Projet_SN_1.Jeu;


using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projet_SN_1
{
    class Program
    {
        static bool Is_Game_Over = false;
        static void Main(string[] args)
        {

            Menu test = new Menu();
            Interface i = new Interface();
            while (Is_Game_Over != true)
            {
                Thread.Sleep(250);
            }

        }
    }
}
