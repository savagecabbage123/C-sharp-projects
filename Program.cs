using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //a string list called opList
            List<string> opList = new List<string>();
            opList.Add("/");
            opList.Add("+");
            opList.Add("-");
            opList.Add("*");
            //writes calculator
            Console.WriteLine("Calculator");
            //writes put in a number
            Console.Write("put in a number: ");
            //lets you input something and is called num1
            string num1 = Console.ReadLine();
            double number;
            double number2;
            number = Convert.ToDouble(num1);
            //writes put in another number
            Console.Write("put in another number: ");
            //lets you input something and is called num2
            string num2 = Console.ReadLine();
            number2 = Convert.ToInt32(num2);
            //tells what you chose on both num vars and asks what calculation you want
            Console.Write("This is your first number {0}", num1);
            Console.WriteLine(" and this is your second number {0}", num2);
            Console.WriteLine("Choose what operation you would like to do with these two numbers: ");
            //displays your list you made
            foreach (string a in opList)
                Console.WriteLine(a);
            //lets you input your operator
            string op = Console.ReadLine();
            //function called calculate when it is called it does a small "animation" with text
            void Calculate()
            {
                Console.Write("Calculating.");
                //tells program to wait between each line
                System.Threading.Thread.Sleep(700);
                Console.Write(".");
                System.Threading.Thread.Sleep(700);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(700);
            }
            //checks if your input is equal to this operator on the list 
            if (op == "/")
            {
                //calls the calculate function
                Calculate();
                //calculates results
                Console.WriteLine("Results: ", number / number2);
            }
            if (op == "*")
            {
                //calls the calculate function
                Calculate();
                //calculates results
                Console.WriteLine("Results: ", number * number2);
            }
            if (op == "+")
            {
                //calls the calculate function
                Calculate();
                //calculates results
                Console.WriteLine("Results: ", number + number2);
            }
            if (op == "-")
            {
                //calls the calculate function
                Calculate();
                //calculates results
                Console.WriteLine("Results: ", number - number2);
            }
        }
    }
}
