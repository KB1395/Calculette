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


            // Parcours de tout le contenu de l'assembly //to get all the informations
            foreach (Type t in computer.GetTypes())
            {
                // Filtre pour ne garder que les classes
                // qui implémentent l'interface "Computer"
                //We set by default the adder as "t"
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t))
                {
                    Console.WriteLine(">>> Calling: " + t.Name);

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

            Console.ReadKey();
        }
	}
}
