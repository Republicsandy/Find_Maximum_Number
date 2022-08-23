using System;

namespace Find_Max_Num_Using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to MaximumTest using Generics!");
            int MaximumInt = Max_Num_Check.MaxIntgerNum(30, 20, 10);
            Console.WriteLine("Maximum integer value is : " + MaximumInt);
        }
    }
}
