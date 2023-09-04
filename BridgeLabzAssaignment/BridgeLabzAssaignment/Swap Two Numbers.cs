using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzAssaignment
{
     public class Swap_Two_Numbers
    {
        public static void STN()
        {

            Console.WriteLine("Enter the number");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;      
            b = a / b;       
            a = a / b; 
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
