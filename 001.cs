public class One
{
	public static void Main()
   	{
		int sum = 0;
      		for(int i = 0; i < 1000; ++i){
      			if(i % 5 == 0 || i % 3 == 0)
				sum += i;
		}
		System.Console.WriteLine(sum);
	}
}

