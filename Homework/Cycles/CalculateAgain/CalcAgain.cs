//Write a program that calculates N! / K! for given N and K.

//Use only one loop.
//Input

//On the first line, there will be only one number - N
//On the second line, there will be only one number - K
//Output

//Output a single line, consisting of the result from the calculation described above.
//Constraints

//1 < K < N < 100
//Hint: overflow is possible
//N and K will always be valid integer numbers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input	Output
//5
//2	60
//6
//5	6
//8
//3	6720

using System;

class CalcAgain
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        long k = int.Parse(Console.ReadLine());
        long nFacturial = 1;
        long kFacturial = 1;
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            nFacturial *= i; 
        }
        for (int j = 1; j <= k; j++)
        {
            kFacturial *= j;
        }
        result = nFacturial / kFacturial;
        Console.WriteLine(result);
    }
}

