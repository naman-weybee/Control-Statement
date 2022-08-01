using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueStatement
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    for(int i = 0; i < 10; i++)
        //    {
        //        if(i == 5)
        //        {
        //            continue;
        //        }
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}

        public static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (i == 2 && j == 1)
                    {
                        continue;
                    }
                    Console.WriteLine(i + " " + j);
                }
            }
            Console.ReadLine();
        }
    }
}
