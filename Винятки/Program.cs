using System;
using System.Collections.Generic;
using System.Text;

public class CalculatorException : Exception
{
    public CalculatorException(string message) : base(message)
    {
    }
}
class Program
{
    static double DivideNumbers(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            throw new CalculatorException("Division by zero is not allowed");
        }
        return dividend / divisor;
    }
    //////////////////////////////////////////////////////////////
        static int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }

        return dividend / divisor;
    }
    static void Main(string[] args)
    {
        //try
        //{
        //    int result = Divide(10, 9);
        //    Console.WriteLine($"Result: {result}");
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Error: Division by zero is not allowed.");
        //    Console.WriteLine($"Exception Details: {ex.Message}");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("An error occurred.");
        //    Console.WriteLine($"Exception Details: {ex.Message}");
        //}
        /////////////////////////////////////////////////////////////////

        try
        {
            double result = DivideNumbers(10, 0);
            Console.WriteLine($"Result: {result}");
        }
        catch (CalculatorException ex)
        {
            Console.WriteLine("Error: Division by zero");
            Console.WriteLine(ex.Message);
        }
    }

    
}

