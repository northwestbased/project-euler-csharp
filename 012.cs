using System;


public class Twelve
{
    public static void Main()
    {
        ulong current = 1;
        ulong sum = 1;
        while(Find_Divisors(current) < 500)
        {
            sum += 1;
            current += sum;
        }

        Console.WriteLine(current);
    }
    

    private static int Find_Divisors(ulong num)
    {
        int divisors = 2;

        for (ulong i = (ulong)Math.Sqrt(num) - 1; i > 1; i--)
        {
            if (num % i == 0)
            {
                ++divisors;
            }
            if (num % 2 == 1 && i % 2 == 0)
                --i;
        }
        divisors = divisors * 2;
        if (Math.Sqrt(num) * Math.Sqrt(num) == num)
            divisors += 1;

        return divisors;
    }
}

