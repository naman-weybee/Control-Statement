using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statement
{
    public class ifExample
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a Number");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    if(num % 2 == 0)
        //    {
        //        Console.WriteLine("{0} is even number", num);
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} is odd number", num);
        //    }
        //        Console.ReadLine();
        //}
        public static void Main(string[] args)
        {
            int Marks = Convert.ToInt32(Console.ReadLine());
            if (Marks < 0 || Marks > 100)
            {
                Console.WriteLine("Invalid input");
            }
            else if (Marks >= 0 && Marks < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (Marks >= 50 && Marks < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (Marks >= 60 && Marks < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (Marks >= 70 && Marks < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (Marks >= 80 && Marks < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (Marks >= 90 && Marks <= 100)
            {
                Console.WriteLine("A+ Grade");
            }
            Console.ReadLine();
        }
    }
}

