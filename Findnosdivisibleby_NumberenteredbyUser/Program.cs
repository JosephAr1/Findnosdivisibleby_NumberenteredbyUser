using System;

namespace Findnosdivisibleby_NumberenteredbyUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, i;
            
            Console.WriteLine("Please enter a number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=10;i++)
            {                
             Console.WriteLine(number1.ToString() + " * " + i + " = " + (number1).ToString());           
             }
        }
    }
}
