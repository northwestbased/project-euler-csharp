using System;

public class SevenTeen
{
    public static void Main()
    {

        int count = 0;
        int current;

        int[] ones_place = { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4};
        int[] tens_place = { 0, 3, 6, 6, 5, 5, 5, 7, 6, 6 };
        int[] eleven_nineteen = { 0, 6, 6, 8, 8, 7, 7, 9, 8, 8 };

        for (int i = 1; i <= 1000; ++i)
        {
            // 10's and 1's
            current = i % 100;
            if (current < 10 || current > 19)
            {
                count += ones_place[current % 10];
            }
            else
                count += eleven_nineteen[current - 10];
            if (current > 19)
            {
                count += tens_place[current / 10];
            }
            if (current == 10)
                count += 3;


            // 100's
            current = i / 100 % 10;
            if (current > 0)
            {
                count += ones_place[current] + 7;
            }

            // 1000's
            if(i == 1000)
            {
                count += 11;
            }

            if (i / 100 > 0 && i % 100 > 0) //account for "and" between 100's and 10'
            {
                count += 3;
            }
        }
        Console.WriteLine(count);
    }
}


