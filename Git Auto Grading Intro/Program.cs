using System;

namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here
            int addResult = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + addResult);

            int subtractResult = Subtract(5, 2);
            Console.WriteLine("The result of subtracting 2 from 5 is: " + subtractResult);

            int multiplyResult = Multiply(4, 3);
            Console.WriteLine("The result of multiplying 4 and 3 is: " + multiplyResult);

            try
            {
                decimal divideResult = Divide(10, 2);
                Console.WriteLine("The result of dividing 10 by 2 is: " + divideResult);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Methods Here
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static decimal Divide(int a, int b)
        {
        
            return (decimal)a / b;
        }
    }
}

