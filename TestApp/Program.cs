using ClassLibrary1;
using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberAction numberAction = new NumberAction();
            string keyboardInput;
            int first,second;
            Console.WriteLine("Enter first number");
            keyboardInput=Console.ReadLine();
            while (!Int32.TryParse(keyboardInput, out first)) {
                Console.WriteLine("Please, try again. The value should be integer.");
                keyboardInput = Console.ReadLine();
            }
            Console.WriteLine("Enter second number");
            keyboardInput = Console.ReadLine();
            while (!Int32.TryParse(keyboardInput, out second))
            {
                Console.WriteLine("Please, try again. The value should be integer.");
                keyboardInput = Console.ReadLine();
            }
            if (ConfigurationManager.AppSettings["useMethods"].Equals("1"))
            {
                Console.WriteLine("Result of addition:" + numberAction.Addition(first, second));
                Console.WriteLine("Result of subtraction:" + numberAction.Subtraction(first, second));
                Console.WriteLine("Result of multiplication:" + numberAction.Multiplication(first, second));
                Console.WriteLine("Result of division:" + numberAction.Division(first, second));
            }
            else
            {
                Console.WriteLine("Result of addition:" + (first + second));

            }
        }
    }
}
