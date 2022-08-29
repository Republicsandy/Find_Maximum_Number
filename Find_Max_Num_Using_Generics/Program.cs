using System;

namespace Find_Max_Num_Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Find MaximumTest using Generics!");
            int getValueByUser = Convert.ToInt32(Console.ReadLine());
            switch (getValueByUser)
            {
                case 1:
                    int maximumInteger = Max_Num_Check.MaximumIntgerNumber(30, 20, 10);
                    Console.WriteLine("Maximum integer value is : " + maximumInteger);
                    break;
                case 2:
                    float maximumFloatNumber = Max_Num_Check.MaximumFloatNumber(111.2f, 22.45f, 78.56f);
                    Console.WriteLine("Maximum float value is : " + maximumFloatNumber);
                    break;
                case 3:
                    string maximumString = Max_Num_Check.MaximumStringValue("Apple", "Peach", "Banana");
                    Console.WriteLine("Maximum string value is : " + maximumString);
                    break;
                default: throw new Exception("invaled Number enterd");
            }
           
        }
    }
}
