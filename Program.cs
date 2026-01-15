using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of times to roll: ");
        int rolls = int.Parse(Console.ReadLine());

        Console.WriteLine($"Rolling the dice {rolls} times...\n");

        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(rolls);



        System.Console.WriteLine("Distribution of rolls:");

        for (int i = 2; i <= 12; i++)
        {
            double percent = (double)results[i] / rolls * 100;

            Console.Write($"{i}: ");

            int stars = (int)percent;

            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
}
