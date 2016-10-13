using System;

public class Four
{
	public static void Main()
   	{
		int m = 999;
		int n = 999;
		
		int largest_current = 0;

		while(n >= 100 && n * 999 > largest_current){

			bool result = isPalindrome(m*n);
			if(result && m*n > largest_current)
				largest_current = m*n;

			if(m == 999){
				m = --n;
			}
			else
				++m;
		}
		Console.WriteLine(largest_current);
	}

	private static bool isPalindrome(int num){
		string number = num.ToString();
		
		int half_len = number.Length/2;
		string first_half = number.Substring(0, half_len);
		string second_half = number.Substring(number.Length - half_len);

		char [] second_half_arr = second_half.ToCharArray();
		Array.Reverse(second_half_arr);
		second_half = new string(second_half_arr);
		
		if(first_half == second_half)
			return true;
		else
			return false;
	}
}
