using System;

public class Five
{
	public static void Main()
   	{
		long current_max = 1;
		for(int i = 11; i<=20; ++i){
			current_max *= i;
		}
		long current = current_max;

		while(current > 20){
			bool flag = true;
			for(int i = 11; i <= 20 && flag == true; ++i){
				if(current % i != 0)
					flag = false;
			}
			if(flag == true){
				current_max = current;
			}
			current -= 923780;
		}
		Console.WriteLine(current_max);
	}
}
