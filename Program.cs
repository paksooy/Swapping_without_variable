using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj_Basvuru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number: {0}   Second Number: {1}", firstNumb, secondNumb);
            firstNumb = firstNumb ^ secondNumb;
            secondNumb = firstNumb ^ secondNumb;
            firstNumb = firstNumb ^ secondNumb;
            Console.WriteLine("The no-variable swap is successful.");
            Console.WriteLine("First Number: {0}   Second Number: {1}", firstNumb, secondNumb);
            Console.ReadKey();
        }
    }
}
