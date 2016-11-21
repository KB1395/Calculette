using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace Cours5
{
	public class Program
	{
		public static void Main (string[] args)
		{
			// Ouverture du fichier texte
			// et lecture de tout son contenu, ligne par ligne
			string[] content = File.ReadAllLines ("data.txt");

			// Conversion de chacune des lignes du fichier texte lu
			// en un nombre flottant de type double
			double[] data = new double[content.Length];
			for (int i = 0; i < content.Length; i++)
			{
				data[i] = System.Convert.ToDouble (content[i]);
			}

			// Chargement de l'assembly Computer.dll
			Assembly computer = Assembly.LoadFrom ("/Users/combefis/Desktop/Computer.dll");

			// Parcours de tout le contenu de l'assembly
			foreach (Type t in computer.GetTypes())
			{
				// Filtre pour ne garder que les classes
				// qui implémentent l'interface "Computer"
				if (t.IsClass && typeof (Computer.Computer).IsAssignableFrom (t))
				{
					Console.WriteLine (">>> Calling: " + t.Name);

					// Création d'un instance de la classe de type "t"
					// et on peut l'affecter à une variable de type "Computer"
					// puisqu'elle implémente cette interface
					Computer.Computer c = (Computer.Computer) Activator.CreateInstance (t);

					// Appel de la méthode "Compute" avec les données
					// qui ont été extraites du fichier
					Console.WriteLine ("Result: " + c.Compute (data));
				}
			}
		}
	}
}
