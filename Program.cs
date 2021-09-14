using System;

namespace Dice_rolling
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("In this program you will roll 2 dice at a time until you get a pair");
            Random numGen = new Random();
            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;
            Console.WriteLine("press the enter key to roll 2 dice");
            while (roll1 != roll2)
            {
                Console.ReadKey();
                roll1 = numGen.Next(1, 7);
                roll2 = numGen.Next(1, 7);
                Console.WriteLine("Dice1 " + roll1);
                Console.WriteLine("Dice2 " + roll2 + "\n");
                attempts++;
            }
            Console.WriteLine("it took you " + attempts + " attempts to roll a 2 of a kind");
        }
    }
}
