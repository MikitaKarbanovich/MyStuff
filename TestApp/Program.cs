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
            WitterAndReader witterAndReader = new WitterAndReader();
            int first, second;
            first = witterAndReader.NumberReader();
            second = witterAndReader.NumberReader();
            witterAndReader.ResultWritter(first, second);
        }
       
    }
}
