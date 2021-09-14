using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // init variables
            string profession, store;
            string[] emotion = new string[2], food = new string[2];
            // get input from user
            Console.WriteLine("hello and welcome to madlibs!");
            Console.WriteLine("please name any job/profession that you know or have");
            profession = Console.ReadLine();
            Console.WriteLine($"wow being a {profession} is very cool we will use that info later");
            Console.WriteLine("Alright now name your favorite grocery store you like to go to");
            store = Console.ReadLine();
            Console.WriteLine($"Okay you like to shop at {store}, that is very cool!");
            Console.WriteLine($"Okay now I need 2 emotions relating to {profession} they can be the same or different");

            for (int i = 0; i < emotion.Length; i++)
            {
                Console.WriteLine($"emotions (plural) {i + 1} / {emotion.Length}");
                emotion[i] = Console.ReadLine();
            }
            Console.WriteLine("Lastly I need 2 of your favorite foods");

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"favorite foods (plural) {i + 1} / {food.Length}");
                food[i] = Console.ReadLine();
            }
            // init story
            string madlibsstory =
            $"The {profession} was very {emotion[0]}," +
            $" he then decided to go to his favorite store {store}" +
            $" and grabbed some {food[0]} off a shelf" +
            $" and he ate some {food[1]} " +
            $"randomly off of a different shelf before buying {food[0]} and was {emotion[1]} again, " +
            $"because of eating {food[1]} without buying it the {profession} was later arrested.";
            // print story
            Console.WriteLine(madlibsstory);
            Console.Read();
        }
    }
}
