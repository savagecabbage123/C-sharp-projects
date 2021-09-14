using System;

namespace word_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence: ");
            wordcount();
        }
        static void wordcount()
        {
            string sentence = Console.ReadLine();
            int count = sentence.Split(' ').Length;
            Console.WriteLine("the sentence has " + count + " words");
        }
    }
}
