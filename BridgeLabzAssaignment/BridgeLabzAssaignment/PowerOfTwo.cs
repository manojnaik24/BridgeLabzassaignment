using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzAssaignment
{
    internal class PowerOfTwo
    {
        public static void PTwo(int mul)
        {
         
            if (mul> 31)
            {
                Console.WriteLine("value of number should be less than 31");
                return;
            }

            else
            {
                for (int j = 1; j <= mul; j++)
                {
                    mul = mul * 2;
                    Console.WriteLine(mul);
                }
            }
        }
    }
}
