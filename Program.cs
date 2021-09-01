using System;

namespace CSharpFundamentals
{
    class Program
    {
        static float n1 = 432, n2 = 543;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var addition = Add(n1, n2);
            Console.WriteLine(addition);
            var substraction = Substract(n1, n2);
            Console.WriteLine(substraction);
            var multiplication = Multiply(n1, n2);
            Console.WriteLine(multiplication);
            var division = Divide(n1, n2);
            Console.WriteLine(division);
        }

        private static float Add(float n1, float n2)
        {
            var result = n1 + n2;
            return result;
        }

        private static float Substract(float n1, float n2)
        {
            var result = n1 - n2;
            return result;
        }

        private static float Multiply(float n1, float n2)
        {
            var result = n1 * n2;
            return result;
        }

        private static float Divide(float n1, float n2)
        {
            var result = n1 / n2;
            return result;
        }
    }
}
