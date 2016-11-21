using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace Calcu_main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ouverture du fichier texte
            // et lecture de tout son contenu, ligne par ligne
            string[] data = File.ReadAllLines("data.txt");

            // Chargement de l'assembly Computer.dll
            Assembly computer = Assembly.LoadFrom(@"..\..\..\Calcu_lib\bin\Debug\Calcu_lib.dll"); //@ allow us to put only one "\"

            //To make a list with all the function possible 
            //We init the variable with the first instruction
            //We don't have to create a constructor in the Main
            //The second instruction is to create my list
            List<string> function; function = new List<string>();

            // Parcours de tout le contenu de l'assembly //to get all the informations
            foreach (Type t in computer.GetTypes())
            {
                // Filtre pour ne garder que les classes
                // qui implémentent l'interface "Computer"
                //We set by default the adder as "t"
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t))
                {
                    Console.WriteLine(">>> Calling: " + t.Name);

                    function.Add(t.Name);

                    // Création d'un instance de la classe de type "t"
                    // et on peut l'affecter à une variable de type "Computer"
                    // puisqu'elle implémente cette interface
                    //We use by default the adder with "t"
                    Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);

                    // Appel de la méthode "Execute" avec les données
                    // qui ont été extraites du fichier
                    Console.WriteLine("Result: " + c.Execute(data));
                }
            }


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

                break;


                switch (Convert.ToString(Console.ReadLine()))  //To make the action of the 4 different possibilities or the default result
                {
                    /*
                     * case "1":
                        Choice1.Init(students);

                        break;
                        */

                    case "help":
                        //List<string>[] = File.ReadAllLines("function.txt");
                        foreach (string Operation in function)
                        {
                            Console.WriteLine(Operation);
                        }
                       
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Chose a valid choice please >:(");
                        break;


                }  
            }         

            Console.ReadKey();
        }
	}
}   
