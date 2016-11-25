using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Calcu_main
{
    //this class allows to open and go trough the dll's 
    public abstract class DllOpener
    {
        public static List<string> Lectures()
        {
            // Loading of both trigonometrics and basic calculus DLL's
            Assembly computer = Assembly.LoadFrom(@"..\..\..\Calcu_lib\bin\Debug\Calcu_lib.dll"); //@ allow us to put only one "\" It was also possible to simply put "/"
            Assembly trigo = Assembly.LoadFrom(@"..\..\..\Trigo_lib\bin\Debug\Trigo_lib.dll"); //@ allow us to put only one "\"

            //To make a list with all the function possible 
            //We init the variable with the first instruction
            //We don't have to create a constructor in the Main
            //The second instruction is to create my list
            List<string> function; function = new List<string>();


            // We go trough every type contained in the DLL's
            foreach (Type t in computer.GetTypes())
            {
                // And we keep only the class that inherit from Computer
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t))
                {

                    // Then create a list that contains every type name and description
                    // in order to create the help command (see program.cs)
                    function.Add(t.Name);
                    // We have to create an instance of the class of type t in order to access its description
                    Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);

                    function.Add(c.Description);                    
                }
            }
            foreach (Type t in trigo.GetTypes())
            {
                // same operations for the trigonometrics dll
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t))
                {
                    function.Add(t.Name);
                    Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);

                    function.Add(c.Description);
                }
            }
            //return of the list with 
            return function;
        }
        //this function recieves the function parameters as an input
        public static string Comparator(string query)
        {
            bool found = false;
            //split of the command parameters
            string[] command = query.Split(' ');
            Assembly computer = Assembly.LoadFrom(@"..\..\..\Calcu_lib\bin\Debug\Calcu_lib.dll");
            Assembly trigo = Assembly.LoadFrom(@"..\..\..\Trigo_lib\bin\Debug\Trigo_lib.dll");
            string result = "";
            //same as the Lectures() function
            foreach (Type t in computer.GetTypes())
            {
                
                //search if the command is in the calcul_lib library
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t) && command[0].Equals(t.Name))
                {

                    if (command.Length == 1 || command.Length==2)
                    {
                        result = "Missing parameters";
                        found = true;
                        break;
                    }
                    //if we have more parameters , an array is created wich every parameter
                    if (command.Length > 2)
                    {
                        List<string> comparams = new List<string>();

                        for (int i = 1; i < command.Length; i++)
                        {
                            comparams.Add(command[i]);
                        }
                        //Instanciation of the type t class
                        Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);
                        //execution with the given params
                        result = "Result: " + c.Execute(comparams.ToArray());
                        found = true;
                        break;

                    }
                    
                }




                else { result = ""; }
            }
            //search if the command is in the trigonometrics library
            foreach (Type t in trigo.GetTypes())
            {
                Console.Clear();
                if (command.Length == 1)
                {
                    result = "Missing parameters";
                    found = true;
                    break;
                }
                
                if (t.IsClass && typeof(Computer.Computer).IsAssignableFrom(t) && command[0].Equals(t.Name))
                {
                    if (command.Length > 2)
                    {
                        result = "too many parameters (Only one needed)";
                        found = true;
                        break;
                    }
                    else
                    {
                        Computer.Computer c = (Computer.Computer)Activator.CreateInstance(t);
                        result = "Result: " + c.Execute(command[1]);
                        found = true;
                        break;
                    }
                }
            

            }
            if (!found) { result = "command not found"; }
            return result;
            



        }
    }
}
