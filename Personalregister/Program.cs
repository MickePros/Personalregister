


using System.Collections.Generic;

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> register = new List<string>();

            Greeting(register);
        }

        private static void Greeting(List<string> register)
        {
            Console.Clear();
            Console.WriteLine("Hello and welcome to the employee register, What would you like to do?");
            Console.WriteLine("Provide me a number or keyword:");
            Console.WriteLine("1) [ADD] employee to the register");
            Console.WriteLine("2) [PRINT] entire register");
            Console.WriteLine("3) [REMOVE] employee from the register (WIP)");
            Console.WriteLine("4) [EMPTY] the register (WIP)");
            Console.WriteLine("5) [GOOD] bye, have a nice day.");
            String input = Console.ReadLine();
            if (input == "1" || input == "ADD")
            {
                AddEmployee(register);
            }else if (input == "2" || input == "PRINT")
            {
                PrintRegister(register);

            }
            else if (input == "5" || input == "GOOD")
            {
                Console.WriteLine("Good bye.");
            }
            else
            {
                Console.WriteLine("I did not understand you, shutting down.");
            }
        }

        private static void PrintRegister(List<string> register)
        {
            Console.Clear();
            String[] employeeList = register.ToArray();
            for (int i = 0; i < employeeList.Length; i++)
            {
                Console.WriteLine("{0}", employeeList[i]);
            }
            Console.Write("Back to start.");
            Console.ReadLine();
            Greeting(register);
        }

        private static void AddEmployee(List<string> register)
        {
            Console.Clear();
            while (true)
            {
                String employee = "";
                Console.Write("Tell me the name of the employee: ");
                employee = Console.ReadLine();
                Console.Write("Tell me the salary of {0}: ", employee);
                employee = employee + " " + Console.ReadLine();
                register.Add(employee);
                Console.Write("Would you like to add another employee? (yes/no)");
                String input = Console.ReadLine();
                if (input == "no")
                {
                    break; 
                }
            }
            Greeting(register);
        }
    }
}
