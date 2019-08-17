using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            hidden = rand.Next(100);
            while (true)
            {
                Console.Write("Enter the Random Number :");
                int userGuess = Int32.Parse(Console.ReadLine());

                if(userGuess==hidden)
                {
                    break;
                }
                else if (userGuess> hidden && userGuess>0 && userGuess<101)
                {
                    Console.WriteLine("Too High!");
                }
                else if (userGuess < hidden && userGuess > 0 && userGuess < 101)
                {
                    Console.WriteLine("Too Low!");
                }
                else
                {
                    Console.WriteLine("Number out the Range");
                }
               
            }
            Console.WriteLine("Congrats You Are The WINNER !");
            Console.ReadLine();
        }
    }
}
