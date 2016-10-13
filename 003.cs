using System;

public class Three
{
	public static void Main()
   	{
		long num =  600851475143;
		long max_factor = (long) Math.Floor(Math.Sqrt(num));
		long factor = 2;

		while(factor <= max_factor && factor < num){
			if(num % factor == 0){
				num = num/factor;
				factor = 1;
			}
			++factor;
		}
		Console.WriteLine(num);
	}
}

