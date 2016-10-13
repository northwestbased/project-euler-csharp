using System;

public class Nine
{
	public static void Main()
   	{
		int a = 1, b = 1, c = 1;

		while(!(a*a + b*b == c*c && a + b + c == 1000)){
			if(1000 - a - b <= b){
				b = a++;
				c = b;
			}
			else if(c == 1000 || c*c > a*a+b*b)
				c = ++b + 1;
			else
				++c;
		}

		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(a * b * c);
	}
}
