using System;

public class Seven
{
	public static void Main()
   	{
		int count = 1;
		
		int i;
		
		for(i = 3; count < 10001; i += 2){
			if(isPrime(i))
				++count;
		}

		Console.WriteLine(i-2);

		
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


