using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Reflection;
>>>>>>> b649d4e... ajout de sprite
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1.Jeu
{
    class Menu
    {
<<<<<<< HEAD
=======
        public int Difficulty;

        public Menu()
        {
            Console.WriteLine("Choose your difficulty:\n1(boooorrinnng...) | 2(Mh..) | 3(You sure about that ?)");
            Console.Write(">");
            var input = Console.ReadLine();
            while (input == "" || (input != "1" && input != "2" && input != "3" && input != "DEBUG"))
            {
                Console.WriteLine("I don't understand your answer.\nPlease Try again\n1(boooorrinnng...) | 2(Mh..) | 3(You sure about that ?)");
                Console.Write(">");
                input = Console.ReadLine();
                //Console.WriteLine($"[{input}]");
            }
            switch (input)
            {
                case "1":
                    {
                        Difficulty = 1;
                        break;
                    }
                case "2":
                    {
                        Difficulty = 2;
                        break;
                    }
                case "3":
                    {
                        Difficulty = 3;
                        break;
                    }
                default:
                    {
                        Difficulty = 0;
                        Console.WriteLine("Cheater... >:(");
                        break;
                    }
            }
            Console.WriteLine("Press any key for start.");
            Console.ReadLine();
            //Lance le jeu -> Crée la scene puis les sprites

        }
>>>>>>> b649d4e... ajout de sprite
    }
}
