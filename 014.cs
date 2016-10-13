using System;

public class Fourteen
{
    public static void Main()
    {
        long longest_length = 1;
        long longest_num = 1;
        long current_length;
        long num;
        for (long i = 999999; i > 1; --i)
        {
            num = i;
            current_length = 1;
            while (num > 1)
            {
                ++current_length;
                if (num % 2 == 0)
                    num /= 2;
                else
                    num = 3 * num + 1;
            }
            if (current_length > longest_length)
            {
                longest_length = current_length;
                longest_num = i;
            }
        }

        Console.WriteLine(longest_num);
    }
}

