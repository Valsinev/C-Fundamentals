//Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//Use only one loop. Print the result with 5 digits after the decimal point.
//Input

//On the first line you will receive one number - N.
//On the second line you will receive another number - x.
//Output

//Output only one number - the sum of the sequence for the given N and x.
//Constraints

//N will always be a valid integer between 2 and 20, inclusive.
//X will always be a valid floating-point number between -100 and 100
//X * N will always be less than 50
//Time limit: 0.1s
//Memory limit: 16MB


using System;
class CalculateFactutiels
{
    static void Main()
    {
        long facturial = 1;
        double sum = 1;
        Console.Write("Enter first integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        double x = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            facturial *= i;
            sum += (facturial / Math.Pow(x, i));
        }
        Console.WriteLine(sum);
    }
}

