using System;


public class Fifteen
{
    public static void Main()
    {
        ulong[,] grid = new ulong[21, 21];

        for (int i = 0; i < 21; ++i) {
            grid[0, i] = 1;
            grid[i, 0] = 1;
        }

        for(int i = 1; i < 21; ++i)
        {
            for(int j = 1; j < 21; ++j)
            {
                grid[i, j] = grid[i, j - 1] + grid[i - 1, j];
            }
        }
        ulong a = grid[20, 20];
        Console.WriteLine(grid[20, 20]);
    }
}

