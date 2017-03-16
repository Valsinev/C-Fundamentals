﻿//Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if
//the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B, separated by a space.
//Input
//On the first line, you will receive the value of A
//On the second line, you will receive the value of B
//Output
//On the only output line, print the values of the two variables, separated by a whitespace
//Constraints
//A and B will always be valid real numbers between -100 and 100
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input	Output
//5
//3	3 5
//2
//4	2 4
//3.3
//3.3	3.3 3.3


using System;

class ExchangeGreater
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.Write("Result is: ");
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            Console.Write("Result is: ");
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

