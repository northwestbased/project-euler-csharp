using System;

public class Nine
{
	public static void Main()
   	{
		long count = 2;

		for(int i = 3; i < 2000000; i += 2){
			if(isPrime(i))
				count += i;
		}

		Console.WriteLine(count);
	}

	private static bool isPrime(int num)
	{
		if(num == 2)
			return true;
		else if(num == 1 || num == 0 || num % 2 == 0)
			return false;
		for(long i = 3; i <= Math.Sqrt(num); i += 2){
			if(num % i == 0)
				return false;
		}
		

		return true;
	}
}
