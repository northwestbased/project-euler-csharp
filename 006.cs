using System;

public class Six
{
	public static void Main()
   	{
		long sum_squares = 0;
		long square_sums = 0;

		for(int i = 100; i > 0; --i){
			sum_squares += i*i;
			square_sums += i;
		}
		
		square_sums *= square_sums;

		Console.WriteLine(square_sums - sum_squares);
	}
}
