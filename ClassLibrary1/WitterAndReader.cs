using System;
using System.Configuration;

namespace ClassLibrary1
{
    public class WitterAndReader
    {
        public int NumberReader()
        {
            string keyboardInput;
            int resOfReading;
            if (ConfigurationManager.AppSettings["useResFile"].Equals("1"))
            {
                keyboardInput = NumberResource.ResourceManager.GetString("first");
                if (Int32.TryParse(keyboardInput, out resOfReading))
                {
                    Console.WriteLine("Error: The value in resx file should be integer.");
                }
            }
            else
            {
                Console.WriteLine("Enter numeral, please");
                keyboardInput = Console.ReadLine();
                while (!Int32.TryParse(keyboardInput, out resOfReading))
                {
                    Console.WriteLine("Please, try again. The value should be integer.");
                    keyboardInput = Console.ReadLine();
                }
            }
            return resOfReading;
        }
        public void ResultWritter(int first, int second)
        {
            NumberAction numberAction = new NumberAction();
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
