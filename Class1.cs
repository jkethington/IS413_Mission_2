using System;

public class DiceRoller
{
    public int[] RollDice(int numberOfRolls)
    {
        Random rand = new Random();
        int[] results = new int[13]; // index = dice sum

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            int sum = die1 + die2;

            results[sum]++;
        }

        
        return results;
    }
}
