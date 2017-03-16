//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

//Input
//The input will consist of a single line - the number N
//Output
//The output should consist of a single line - the numbers from 1 to N, separated by a whitespace

using System;
class OneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.Write(counter + " ");
            counter++;
        }
    }
}

