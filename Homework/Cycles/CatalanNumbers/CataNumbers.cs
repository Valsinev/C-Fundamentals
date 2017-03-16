//Description
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the Nth Catalan number by given N
//Input
//On the only line, you will receive the number N
//Output
//Output a single number - the Nth Catalan number
//Constraints
//N will always be a valid integer number in the range [0, 100]
//Hint: overflow is possible.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input	Output
//0	1
//5	42
//10	16796
//15	9694845

using System;
class CataNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            for (int j = i+1; j < n+i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
