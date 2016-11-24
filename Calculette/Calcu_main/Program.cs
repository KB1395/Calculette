using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace Calcu_main
{
    public class Program:DllOpener
    {
        public static void Main(string[] args)
        {
            // Ouverture du fichier texte
            // et lecture de tout son contenu, ligne par ligne
            string[] data = File.ReadAllLines("data.txt");

            // Chargement de l'assembly Computer.dll
            


            while (true) //To compose our menu
            {

                double width = Console.WindowWidth; //To define the width of the window

                for (int i = 0; i < ((width / 2) - 17); i++) //To make a beautiful title
                {
                    Console.Write("=");
                }
                Console.Write("Bienvenue dans Super Calculator 3.1");
                for (int i = 0; i < ((width / 2) - 18); i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine(" ");
                Console.WriteLine("-To use our Super Calculator you just have to select a function");
                Console.WriteLine(" and give the differents parameters");
                Console.WriteLine("-If you don't know which function are possible, just ask for 'help' !");
                Console.WriteLine("-If you're finish, just write 'exit'");
                Console.WriteLine(" ");



                string query = Convert.ToString(Console.ReadLine());
                switch (query)  //To make the action of the 4 different possibilities or the default result
                {                  
                    case "help":
                        Console.Clear();
                        List<string> function = DllOpener.Lectures();
                        for (int n=0; n<function.Count;n++)
                        {
                            Console.Write(function[n]);
                            Console.Write("       ");
                            n = n + 1;
                            Console.WriteLine(function[n]);
                        }
                        Console.WriteLine();
                        
                        Console.WriteLine();
                        Console.WriteLine("Press any key to get back to the menu");
                        Console.ReadKey();
                        Console.Clear();
                       
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine(DllOpener.Comparator(query));
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }  
            }         

            
        }
	}
}   
