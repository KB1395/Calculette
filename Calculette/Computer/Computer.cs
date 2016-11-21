using System;

namespace Computer
{
	public interface Computer
	{
		string Name
		{
			get;
		}

		double Execute (params string[] values);
	}
}


/* while (true) //To compose our menu
            {

                double width = Console.WindowWidth; //To define the width of the window

                for (int i = 0; i< ((width / 2) - 14); i++) //To make a beautiful title
                {
                    Console.Write("=");
                }
                Console.Write("Bienvenue dans Super Calculator 3.1 ");
                for (int i = 0; i< ((width / 2) - 15); i++)
                {
                    Console.Write("=");
                }

                Console.WriteLine("What do you want to compute?");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Multiplication");
                Console.WriteLine("3) Sinus");
                Console.WriteLine("4) Deriveé");
                Console.WriteLine("5) Intégrale");
                Console.WriteLine("6) Exit");

                switch (Convert.ToString(Console.ReadLine()))  //To make the action of the 4 different possibilities or the default result
                {
                    case "1":
                        Choice1.Init(students);

                        break;

                    case "2":
                        Choice2.Init();
                        break;
                    case "3":
                        Choice3.Init();
                        break;
                    case "4":
                        EntityLister.Init();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("(T_T)");
                        Console.WriteLine();
                        Console.WriteLine("You know nothing! Jon Snow!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key when you know");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case "6":
                        Environment.Exit(0);
                        break;



                    default:
                        Console.WriteLine("Chose a valid choice please >:(");
                        break;


                }

    */