using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopStatement
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    for(int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}

        public static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
            Console.ReadLine();
        }

        //public static void Main(string[] args)
        //{
        //    for (; ; )
        //    {
        //        Console.WriteLine("infinite for loop");
        //    }
        //    Console.ReadLine();
        //}
    }
}
