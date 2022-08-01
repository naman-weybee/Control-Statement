using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopStatement
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        int i = 1;
    //        do
    //        {
    //            Console.WriteLine(i);
    //            i++;
    //        } while (i <= 10);
    //        Console.ReadLine();
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        do
    //        {
    //            Console.WriteLine("infinite do while loop");
    //        } while (true);
    //        Console.ReadLine();
    //    }
    //}

    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 3);
            Console.ReadLine();
        }
    }
}
