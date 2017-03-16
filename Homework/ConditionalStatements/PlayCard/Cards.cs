//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
//Input
//On the only line you will receive a single string.
//Output
//Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".
//Constraints
//String length will always be between 1 and 5
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input	Output
//5	yes 5
//1	no 1
//Q	yes Q
//q	no q
//P	no P
//10	yes 10
//500	no 500


using System;

class Cards
{
    static void Main()
    {
        Console.Write("Enter card: ");
        int n = 1;
        string c = Console.ReadLine();
        if (c == "J" ||
            c == "Q" ||
            c == "K")
        {
            Console.WriteLine("Yes {0}", c);
        }
        else
        {
            bool entry = int.TryParse(c, out n);
            if (entry)
            {
                if (n >= 2 && n <= 10)
                {
                    Console.WriteLine("Yes {0}", n);
                }
                else
                {
                    Console.WriteLine("No {0}", n);
                }
            }
        }
    }
}




