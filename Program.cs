using System;

namespace Array_challenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("how many students are in your class?");
            int numstudents;
            numstudents = Convert.ToInt32(Console.ReadLine());
            String[] students = new string[numstudents];
            Console.WriteLine("Type in the names of the number of students");
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("here they are alphabetically");
            Array.Sort(students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
