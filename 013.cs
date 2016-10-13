using System;
using System.IO;

public class Thirteen
{
	public static void Main()
   	{
		string[] lines = File.ReadAllLines("13_input.txt");
		
		int carryover = 0;
		string result = "";
		int sum;
		for(int i = 49; i >= 0; --i){
			sum = carryover;
			for(int j = 0; j < 100; ++j){
				sum += ((int) (lines[j][i] - '0'));
			}
			result = (sum % 10).ToString() + result;
			carryover = sum / 10;
		}
		result = carryover + result;
		Console.WriteLine(result.Substring(0,10));
	}
}
