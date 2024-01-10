using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a number (1-3");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("You have entered 1");
                    break;
                case 2:
                    Console.WriteLine("You have entered 2");
                    break;
                case 3:
                    Console.WriteLine("You have entered 3");
                    break;
                default:
                    Console.WriteLine("Invalid number, make sure it is between 1 and 3");
                    break;

            }

            Console.Read();
        }
    }
}
