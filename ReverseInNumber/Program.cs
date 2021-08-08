using System;

namespace ReverseInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers to reverse and test");
            int Num = int.Parse(Console.ReadLine());
            int Rev = 0;

            while (Num > 0)
            {
                int rem = Num % 10;
                Rev = (Rev * 10) + rem;
                Num = Num / 10;
            }
            Console.WriteLine("Here reverse number: {0}", Rev);
            Console.ReadLine();
        }
    }
}
