﻿//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g. N = 100000.
//Input
//On the only input line, you will receive a single integer - the number N
//Output
//Output a single number - the count of trailing zeroes for the N!
//Constraints
//N will always be a valid positive integer number.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input	Output	Explanation
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why


using System;
using System.Numerics;
class TrailingZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger[] elements = nFacturial{};
        BigInteger nFacturial = 1;
        //string convert = nFacturial.ToString();
        //string[] elements = {convert};
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            nFacturial *= i;
        }
        foreach (int element in elements)
        {
            
            if (element == 0)
            {
                result++;
                Console.WriteLine(result);
            }
            Console.WriteLine(element);
        }
    }
}

