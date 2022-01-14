using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAllNumbers();
            PrintNumbersByThree();
            PrintEqualOrNot(3, 5);
            PrintEvenOrOdd(8);
            PrintPositiveOrNegative(-5);
            PrintVotingAge();
            CheckRange();
            CalculateProduct();
        }

        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintAllNumbers()  
        {
            Console.WriteLine(" Numbers -1000 to 1000.\n");
           for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);   
              
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void PrintNumbersByThree()
        {
            Console.WriteLine(" Numbers 3 to 999 by 3\'s");
            for (int i = 3; i <= 999; i=i+3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void PrintEqualOrNot(int x, int y)
        {
            var number = (x == y) ? $"\n Numbers {x} and {y} are equal" : $"\n Numbers {x} and {y} are not equal";
            Console.WriteLine(number);
        }

        //Write a method to check whether a given number is even or odd.
        public static void PrintEvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"\n {x} is even.");
            }
            else
            {
                Console.WriteLine($"\n {x} is odd.");
            }
        }

        //Write a method to check whether a given number is positive or negative.
        public static void PrintPositiveOrNegative(int y)
        {
            if (y > 0)
                Console.WriteLine($"\n {y} is positive.");
            else
                Console.WriteLine($"\n {y} is negative.");
        }

        //Write a method to read the age of a candidate and determine whether they can vote. 
        public static void PrintVotingAge()
        {
            Console.WriteLine("\n Enter your age:");
            int age = int.Parse(Console.ReadLine());
            var votingAge = (age >= 18) ? "\n You are able to vote!" : "\n You are still too young to vote";
            Console.WriteLine(votingAge);
        }

        // TODO Write a method to check if an integer(from the user) is in the range -10 to 10.
        public static void CheckRange()
        {
            Console.WriteLine("\n Enter a whole number:");
            int z = int.Parse(Console.ReadLine());

            if (z <= 10 && z>= -10)
            {
                Console.WriteLine($"\n The number {z} is in range -10 to 10.");
            }
            else
            {
                Console.WriteLine($"\n The number {z} is out of the range -10 to 10.");
            }
        }

        // TODO Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void CalculateProduct()
        {
            Console.WriteLine("\n Enter a whole number to multiply by 1 to 12:");
            int a = int.Parse(Console.ReadLine());

           for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * a);
            }
        }

    }
}
