using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzAssaignment
{
    public  class Largest_Among_Three_Numbers
    {
        public static void Largest()
        {

            Console.WriteLine("Enter the number");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());


            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("Number one is the largest!");
                }
                else
                {
                    Console.Write("Number three is the largest!");
                }
            }
            else if (b > c)
            {
                Console.Write("Number two is the largest!");
            }
            else
            {
                Console.Write("Number three is the largest!");
            }
            Console.ReadLine();
         }
    }
}

