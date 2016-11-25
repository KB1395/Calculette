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
            

            
            


            while (true) //To compose our menu
            {

                double width = Console.WindowWidth; //To define the width of the window

                for (int i = 0; i < ((width / 2) - 17); i++) //To make a beautiful title
                {
                    Console.Write("=");
                }
                Console.Write("Welcome in the Super Calculator 3.1");
                for (int i = 0; i < ((width / 2) - 18); i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine(" ");
                Console.WriteLine("-To use our Super Calculator you just have to select a function");
                Console.WriteLine(" and give the differents parameters");
                Console.WriteLine("-If you don't know which function are possible, just ask for 'help' !");
                Console.WriteLine("-If you're done, just type 'exit'");
                Console.WriteLine(" ");



                string query = Convert.ToString(Console.ReadLine());
                //classic menu
                switch (query)  
                {                  
                    case "help":
                        Console.Clear();
                        List<string> function = DllOpener.Lectures();
                        for (int n=0; n<function.Count;n++)
                        {
                            Console.Write(function[n]);
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
