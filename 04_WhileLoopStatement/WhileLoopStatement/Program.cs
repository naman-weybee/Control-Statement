using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopStatement
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    int i = 1;
        //    while(i <= 10)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //    }
        //    Console.ReadLine();
        //}


        //public static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("infinite while loop");
        //    }
        //    Console.ReadLine();
        //}

        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 3)
            {
                int j = 1;
                while (j <= 3)
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
