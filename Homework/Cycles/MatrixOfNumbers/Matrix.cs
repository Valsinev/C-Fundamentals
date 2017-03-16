//Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.
//Challenge: achieve the same effect without nested loops
//Input
//The input will always consist of a single line, which contains the number N
//Output
//See the examples.
//Constraints
//1 <= N <= 20
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input	Output
//2	1 2
//  2 3
//3	1 2 3
//  2 3 4
//  3 4 5
//4	1 2 3 4
//  2 3 4 5
//  3 4 5 6
//  4 5 6 7


using System;
class Matrix
{
    static void Main()
    {
        Console.Write("Enter positive number between 1 and 20: ");
        int n = 0;
        bool entry = int.TryParse(Console.ReadLine(), out n);
        if (n >= 1 &&
            n <= 20 &&
            entry)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                for (int j = i + 1; j < n + i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid entry!");
        }
    }
}

