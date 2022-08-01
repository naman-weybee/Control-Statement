using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakStatement
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    for(int i =0; i < 10; i++)
        //    {
        //        if(i == 5)
        //        {
        //            break;
        //        }
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}

        //public static void Main(string[] args)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (i == 5)
        //        {
        //            break;
        //        }
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}

        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    if(i == 4 && j == 2)
                    {
                        break;
                    }
                    Console.WriteLine(i + " " + j);
                }
            }
            Console.ReadLine();
        }
    }
}
