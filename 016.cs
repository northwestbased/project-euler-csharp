using System;
using System.Numerics;

public class Sixteen
{
    public static void Main()
    {
        BigInteger bignum = BigInteger.Pow(2, 1000);
        int result = 0;
        while(bignum > 0)
        {
            result += (int)BigInteger.Remainder(bignum, 10);
            bignum = BigInteger.Divide(bignum, 10);
        }

        Console.WriteLine(result);
    }

}

