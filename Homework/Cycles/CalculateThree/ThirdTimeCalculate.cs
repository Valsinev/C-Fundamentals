//In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of combinations)
//is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task
//is to write a program that calculates N! / (K! * (N - K)!) for given N and K.
//Try to use only two loops.
//Input
//On the first line, there will be only one number - N
//On the second line, there will also be only one number - K
//Output
//On the only output line, write the result of the calculation for the provided N and K
//Constraints
//1 < K < N < 100
//Hint: overflow is possible
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input	Output
//3 
//2	3
//4 
//2	6
//10
//6	210
//52
//5	2598960


using System;
class ThirdTimeCalculate
{
    static void Main()
    {
        Console.Write("Enter number of members: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter number of elements: ");
        double k = double.Parse(Console.ReadLine());
        double nMinusK = n - k;
        double nFacturial = 1;
        double kFacturial = 1;
        double knFacturial = 1;
        double result = 1;
        if (k > 1 &&
            n > k &&
            100 > n)
        {
            for (int i = 1; i <= n; i++)
            {
                nFacturial *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                kFacturial *= j;
            }
            for (int f = 1; f <= nMinusK; f++)
            {
                knFacturial *= f;
            }
            result = nFacturial / (kFacturial * knFacturial);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }
}