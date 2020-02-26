using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabD
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = 0, second = 0;
            Console.WriteLine("Input first number ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input second number ");
            second = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow((first + second), 2);
            Console.WriteLine(result);
            
        }
    }
}
