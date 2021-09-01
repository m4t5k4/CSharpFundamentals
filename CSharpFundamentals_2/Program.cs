using System;
using CSharpFundamentals_2.Classes;

namespace CSharpFundamentals_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount bankAccount1 = new BankAccount(1f,"me");
            bankAccount1.AddBalance(1f);
            Console.WriteLine(bankAccount1.Balance);

            ChildBankAccount childBankAccount1 = new ChildBankAccount(1f, "kind", "me");
            childBankAccount1.AddBalance(1f, true);
            Console.WriteLine(childBankAccount1.Balance);

            IOperations am = new AdvancedMath();
            Console.WriteLine(am.Remainder(7, 3));
        }

        async static void GetData()
        {
            BankAccount bankAccount = new BankAccount(32f, "Jane");
            Console.WriteLine("logging in");
            var task = await bankAccount.GetData();
            Console.WriteLine(task);
        }
    }

    interface IOperations
    {
        float Remainder(float dividend, float divisor);
    }

    class SimpleMath
    {
        public float Add(float n1, float n2)
        {
            return n1 + n2;
        }
        public float Sub(float n1, float n2)
        {
            return n1 - n2;
        }
        public float Mul(float n1, float n2)
        {
            return n1 * n2;
        }
        public float Div(float n1, float n2)
        {
            return n1 / n2;
        }
    }

    class AdvancedMath : SimpleMath, IOperations
    {
        public float Remainder(float dividend, float divisor)
        {
            return dividend % divisor;
        }
    }
}
