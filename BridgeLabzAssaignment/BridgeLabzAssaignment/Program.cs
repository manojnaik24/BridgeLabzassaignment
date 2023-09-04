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
            Console.WriteLine("Enter the number: ");
            String n=Console.ReadLine();
            Flip_Coin.Flip(int.Parse(n));
            Console.ReadLine();
        }
    }
}
