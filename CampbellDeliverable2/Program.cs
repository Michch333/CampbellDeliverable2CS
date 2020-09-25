using System;
using System.Runtime.CompilerServices;

namespace CampbellDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick Heads or Tails!");
            string headsOrTailsGuess = Console.ReadLine();
            Console.WriteLine("How many times would you like to flip the coin?");
            double numberOfFlips = int.Parse(Console.ReadLine());
            void LetsRoll(string _guess, double _numberOfRolls) {
                Random rnd = new Random();
                double correctCount = 0;
                for (int i = 0; i < _numberOfRolls; i++)
                {
                    int flip = rnd.Next(1, 3);
                    if (flip == 1) {
                        Console.WriteLine("Heads");
                    }
                    if (flip == 2) {
                        Console.WriteLine("Tails");
                    }
                    if (_guess.ToLower() == "heads" && flip == 1)
                    {
                        correctCount++;
                    }
                    if (_guess.ToLower() == "tails" && flip == 2)
                    {
                        correctCount++;
                    }
                };
                double correctPercent = (correctCount / _numberOfRolls * 100);
                Console.Write("Your guess of " + _guess + " was flipped " + correctCount + " times out of " + _numberOfRolls + " giving you a correct percentage of " + correctPercent + "%!");
            }

            LetsRoll(headsOrTailsGuess, numberOfFlips);
            

            
            




        }
    }
}
