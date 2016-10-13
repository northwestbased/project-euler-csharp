using System;
using System.IO;
using System.Collections.Generic;


public class Eleven
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines("C:/Users/Gateway i5/Desktop/csharp_euler/11_input.txt");

        List<int> numbers = new List<int>();

        foreach (string line in lines)
        {
            foreach (string number in line.Split())
            {
                numbers.Add(int.Parse(number));
            }
        }


        int best = 0;


        //horizontal
        for (int i = 0; i < numbers.Count; ++i)
        {
            if (i % 20 > 16)
                continue;


            int count = 1;

            for (int j = 0; j < 4; ++j)
            {
                count *= numbers[i + j];
            }

            if (count > best)
            {
                best = count;
                Console.WriteLine(i);
                Console.WriteLine(best);
            }
        }

        //diagonal nw
        for (int i = 0; i < numbers.Count - 60; ++i)
        {
            if (i % 20 > 16)
                continue;

            int count = 1;
            for (int j = 0; j < 4; ++j)
            {
                count *= numbers[i + j*21];
            }

            if (count > best)
                best = count;
        }


        //vertical
        for (int i = 0; i < numbers.Count - 60; ++i)
        {

            int count = 1;
            for (int j = 0; j < 4; ++j)
            {
                count *= numbers[i + j*20];
            }
            if (count > best)
                best = count;
        }

        //diagonal ne
        for (int i = 0; i < numbers.Count - 60; ++i)
        {
            if (i % 20 < 2)
                continue;

            int count = 1;
            for (int j = 0; j < 4; ++j)
            {
                count *= numbers[i + j * 19];
            }
            if (count > best)
                best = count;
        }
        Console.WriteLine(best);
    }
}

