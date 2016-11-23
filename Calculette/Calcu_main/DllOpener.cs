using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;

namespace Calcu_main
{
    public abstract class DllOpener
    {
        public static List<string> Lectures()
        {
            Assembly computer = Assembly.LoadFrom(@"..\..\..\Calcu_lib\bin\Debug\Calcu_lib.dll"); //@ allow us to put only one "\"
            Assembly trigo = Assembly.LoadFrom(@"..\..\..\Trigo_lib\bin\Debug\Trigo_lib.dll"); //@ allow us to put only one "\"

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
                    

                    function.Add(t.Name);

                    // Création d'un instance de la classe de type "t"
                    // et on peut l'affecter à une variable de type "Computer"
                    // puisqu'elle implémente cette interface
                    //We use by default the adder with "t"
                }
            }
            foreach (Type t in trigo.GetTypes())
            {
                Console.WriteLine(t);
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t))
                {
                    function.Add(t.Name);
                }
            }
            return function;
        }
        public virtual string Comparator(string query)
        {
            string[] command = query.Split(' ');
            Assembly computer = Assembly.LoadFrom(@"..\..\..\Calcu_lib\bin\Debug\Calcu_lib.dll"); 
            Assembly trigo = Assembly.LoadFrom(@"..\..\..\Trigo_lib\bin\Debug\Trigo_lib.dll");
            string result="";

            foreach (Type t in computer.GetTypes())
            {

                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t) && command[0] == t.Name)
                {



                    Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);


                    result= "Result: " + c.Execute(command[1]);
                }
                else { result = ""; }
            }
            foreach (Type t in trigo.GetTypes())
            {
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t) && command[0] == t.Name)
                {
                    Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);
                    result= "Result: " + c.Execute(command[1]);
                }
                else { result= "Command not found"; }
            }
            return result;
            
           

        }
    }
}
