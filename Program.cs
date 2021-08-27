using System;
using static System.Console;
namespace addnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int First_Number, Second_Number, Total;

            WriteLine("Please enter your first number:");
            First_Number = Convert.ToInt32(ReadLine());

            WriteLine("Please enter your second number:");
            Second_Number = Convert.ToInt32(ReadLine());

            Total = (First_Number + Second_Number);
            WriteLine("Your total is {0}", Total);




        }
    }
}
