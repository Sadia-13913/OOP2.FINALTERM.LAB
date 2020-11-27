using System;

namespace Final_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(" Sum = " + c.sum(10,5));
            Console.WriteLine(" Sub = " + c.sub(10,5));
            Console.WriteLine(" Multiplication = " + c.multiplication(50,55));
            Console.WriteLine(" Division = " + c.division(200,55));
            Console.WriteLine(" Power = " + c.XtoY(60,59));
            Console.WriteLine(" Factorial = " + c.factorial(8));
        }
    }
}
