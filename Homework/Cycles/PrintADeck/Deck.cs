//Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard
//deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation
//(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//Input
//On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
//Output
//The output should follow the format bellow(assume our input is 5):  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds 


using System;

class Deck
{
    static void Main()
    {
        int number = 0;
        string n = Console.ReadLine();
        bool check = int.TryParse(n, out number);
        if (n != "j" && 
            n != "J" &&
            n != "q" &&
            n != "Q" &&
            n != "k" &&
            n != "K" &&
            n != "a" &&
            n != "A" &&
            number < 11)
        {
            for (int i = 2; i <= number; i++)
			{	
             Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
        }
        else
        {
            if (n == "j" || n == "J" || number == 11 )
            {
                string jack = "J";
                for (int j = 2; j <= 10; j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
                }
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", jack);
            }
            else if (n == "q" || n == "Q" || number == 12)
            {
                string queen = "Q";
                for (int q = 2; q <= 10; q++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", queen);
            }
            else if (n == "k" || n == "K" || number == 13)
            {
                string king = "K";
                for (int k = 2; k <= 10; k++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", king);
            }
            else if (n == "a" || n == "A" || number == 14)
            {
                string ace = "A";
                for (int a = 2; a <= 10; a++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", a);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", ace);
            }
        }
    }
}

