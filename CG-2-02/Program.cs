using System;

namespace CG_2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the area of a rectangle for you");
            Console.Write("Enter the length of side A: ");
            string sideA = Console.ReadLine();
            Console.Write("Enter the length of side B: ");
            string sideB = Console.ReadLine();

            int sideAnumber = int.Parse(sideA);
            int sideBnumber = int.Parse(sideB);

            int area = sideAnumber * sideBnumber;
            Console.WriteLine("The area of your rectangle is:" + area);
            Console.ReadLine();
        }
    }
}
