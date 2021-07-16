using System;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int X1;
            Console.WriteLine("enter the number X1");
            X1 = Convert.ToInt32(Console.ReadLine());
            if (X1%2 == 0)
            {
                Console.WriteLine("this is a even number");
            }
            else if(X1%2 != 0)
            {
                Console.WriteLine("This is odd number");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
