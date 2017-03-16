//Write a program that reads from the console a sequence of N integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
//The output is like in the examples below.
//Input
//On the first line, you will receive the number N.
//On each of the next N lines, you will receive a single floating-point number.
//Output
//You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second,
//the sum on the third and the average on the fourth, in the following format:
//min=3.00
//max=6.00
//sum=9.00
//avg=4.50

using System;

class MinMaxSumAverage
{
    static void Main()
    {
   int n;
            string[] numbers;
            bool isInteger=true;
            int minimal=int.MaxValue;
            int maximal=int.MinValue;
            Console.Write("Enter a sequence of numbers delimited with \",\":");
            numbers = (Console.ReadLine()).Split(',');
            int[] intNumbers=new int[numbers.Length];
            for (int i = 0; i < (numbers.Length); i++)
            {
                isInteger = int.TryParse(numbers[i], out intNumbers[i]);
                if (isInteger==false)
                {
                    break;
                }
            }
            if (isInteger)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (intNumbers[i] < minimal)
                    {
                        minimal = intNumbers[i];
                    }
                    if (intNumbers[i] > maximal)
                    {
                        maximal = intNumbers[i];
                    }
                }
                Console.WriteLine("minimal={0}",minimal);
                Console.WriteLine("maximal={0}",maximal);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the entries are not integer!");
            }
        }
    }

