using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzAssaignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails"   +
                "2. Leap Year"
                +  "3. Power of 2"  +  
                "4. Harmonic Number"   + 
                "5. Factors"   + 
                "6.  Program to Compute Quotient and Remainder"  +
                "7.  Program to Swap Two Numbers"   + 
                "8.  Program to Check Whether a Number is Even or Odd"   +
                "9. Program to Check Whether an Alphabet is Vowel or Consonant"   +
                "10.  Program to Find the Largest Among Three Numbers");
            Console.WriteLine("Enter the Problem number: ");
            int num=int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1
                    Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
                    Console.WriteLine("Enter the number: ");
                    String n = Console.ReadLine();
                    Flip_Coin.Flip(int.Parse(n));

               


               case 2
                    int y;
                    Console.WriteLine("Enter the Year in Four Digits : ");
                    y = Convert.ToInt32(Console.ReadLine());


                case 3
                    
                    Console.WriteLine("Enter the number: ");
                    int mul = Convert.ToInt32(Console.ReadLine());
                    




            }
            
            
            
            
                

            





            Console.ReadLine();

        }
    }
}
