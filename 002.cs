public class Two
{
	public static void Main()
   	{
		int sum = 0;
		int current = 1;
		int prev = 1;
		while(current <= 4000000){
			if(current % 2 == 0)
				sum += current;
			current += prev;
			prev = current - prev;
		}
		System.Console.WriteLine(sum);
	}
}

