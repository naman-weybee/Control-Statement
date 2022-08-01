using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    public class SwitchCase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 10: 
                    Console.WriteLine("it is 10");
                    break;
                case 5:
                    Console.WriteLine("it is 5");
                    break;
                default:
                    Console.WriteLine("it is not 5 or 10");
                    break;
            }
            Console.ReadLine();
        }
    }
}
