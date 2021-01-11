using System;
using System.Collections.Generic;

namespace CardPEDACCS
{

    class Program
    {
        static void Main(string[] args)
        {

            var deck = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            while (true)
            {
                for (var rightIndex = deck.Count - 1; rightIndex >= 1; rightIndex--)
                {
                    var randomNumberGenerator = new Random();
                    var leftIndex = randomNumberGenerator.Next(rightIndex);
                    var leftCard = deck[leftIndex];
                    var rightCard = deck[rightIndex];
                    deck[leftIndex] = rightCard;
                    deck[rightIndex] = leftCard;
                }
                var zeroCard = deck[0];
                var firstCard = deck[1];
                Console.WriteLine($"The {zeroCard} and {firstCard}");

                if (zeroCard > firstCard)
                {
                    var newLeftCard = deck[0];
                    var newRightCard = deck[1];
                    deck[0] = newRightCard;
                    deck[1] = newLeftCard;
                }


                var secondCard = deck[2];
                Console.WriteLine($"{firstCard} and {secondCard}");

                if (firstCard > secondCard)
                {
                    var newLeftCard = deck[1];
                    var newRightCard = deck[2];
                    deck[1] = newRightCard;
                    deck[2] = newLeftCard;
                }

                var thirdCard = deck[3];
                Console.WriteLine($"{secondCard} and {thirdCard}");

                if (secondCard > thirdCard)
                {
                    var newLeftCard = deck[2];
                    var newRightCard = deck[3];
                    deck[2] = newRightCard;
                    deck[3] = newLeftCard;
                }

                var fourthCard = deck[4];
                Console.WriteLine($"{thirdCard} and {fourthCard}");

                if (thirdCard > fourthCard)
                {
                    var newLeftCard = deck[3];
                    var newRightCard = deck[4];
                    deck[3] = newRightCard;
                    deck[4] = newLeftCard;
                }

                var fifthCard = deck[5];
                Console.WriteLine($"{fourthCard} and {fifthCard}");

                if (fourthCard > fifthCard)
                {
                    var newLeftCard = deck[4];
                    var newRightCard = deck[5];
                    deck[4] = newRightCard;
                    deck[5] = newLeftCard;
                }

                var sixthCard = deck[6];
                Console.WriteLine($"{fifthCard} and {sixthCard}");

                if (fifthCard > sixthCard)
                {
                    var newLeftCard = deck[5];
                    var newRightCard = deck[6];
                    deck[5] = newRightCard;
                    deck[6] = newLeftCard;
                }

                var seventhCard = deck[7];
                Console.WriteLine($"{sixthCard} and {seventhCard}");

                if (sixthCard > seventhCard)
                {
                    var newLeftCard = deck[6];
                    var newRightCard = deck[7];
                    deck[6] = newRightCard;
                    deck[7] = newLeftCard;
                }

                var eighthCard = deck[8];
                Console.WriteLine($"{seventhCard} and {eighthCard}");

                if (seventhCard > eighthCard)
                {
                    var newLeftCard = deck[7];
                    var newRightCard = deck[8];
                    deck[7] = newRightCard;
                    deck[8] = newLeftCard;
                }

                var ninthCard = deck[9];
                Console.WriteLine($"{eighthCard} and {ninthCard}");

                if (eighthCard > ninthCard)
                {
                    var newLeftCard = deck[8];
                    var newRightCard = deck[9];
                    deck[8] = newRightCard;
                    deck[9] = newLeftCard;
                }

                var tenthCard = deck[10];
                Console.WriteLine($"{ninthCard} and {tenthCard}");

                if (ninthCard > tenthCard)
                {
                    var newLeftCard = deck[9];
                    var newRightCard = deck[10];
                    deck[9] = newRightCard;
                    deck[10] = newLeftCard;
                }

                var eleventhCard = deck[11];
                Console.WriteLine($"{tenthCard} and {eleventhCard}");

                if (tenthCard > eleventhCard)
                {
                    var newLeftCard = deck[10];
                    var newRightCard = deck[11];
                    deck[10] = newRightCard;
                    deck[11] = newLeftCard;
                }

                var twelfthCard = deck[12];
                Console.WriteLine($"{eleventhCard} and {twelfthCard}");

                if (eleventhCard > twelfthCard)
                {
                    var newLeftCard = deck[11];
                    var newRightCard = deck[12];
                    deck[11] = newRightCard;
                    deck[12] = newLeftCard;
                }

                var thirteenthCard = deck[13];
                Console.WriteLine($"{twelfthCard} and {thirteenthCard}");

                if (twelfthCard > thirteenthCard)
                {
                    var newLeftCard = deck[12];
                    var newRightCard = deck[13];
                    deck[12] = newRightCard;
                    deck[13] = newLeftCard;
                }

                var fourteenthCard = deck[14];
                Console.WriteLine($"{thirteenthCard} and {fourteenthCard}");

                if (thirteenthCard > fourteenthCard)
                {
                    var newLeftCard = deck[13];
                    var newRightCard = deck[14];
                    deck[13] = newRightCard;
                    deck[14] = newLeftCard;
                }

                var fifteenthCard = deck[15];
                Console.WriteLine($"{fourteenthCard} and {fifteenthCard}");

                if (fourteenthCard > fifteenthCard)
                {
                    var newLeftCard = deck[14];
                    var newRightCard = deck[15];
                    deck[14] = newRightCard;
                    deck[15] = newLeftCard;
                }

                var sixteenthCard = deck[16];
                Console.WriteLine($"{fifteenthCard} and {sixteenthCard}");

                if (fifteenthCard > sixteenthCard)
                {
                    var newLeftCard = deck[15];
                    var newRightCard = deck[16];
                    deck[15] = newRightCard;
                    deck[16] = newLeftCard;
                }

                var seventeenthCard = deck[17];
                Console.WriteLine($"{sixteenthCard} and {seventeenthCard}");

                if (sixteenthCard > seventeenthCard)
                {
                    var newLeftCard = deck[16];
                    var newRightCard = deck[17];
                    deck[16] = newRightCard;
                    deck[17] = newLeftCard;
                }

                var eighteenthCard = deck[18];
                Console.WriteLine($"{seventeenthCard} and {eighteenthCard}");

                if (seventeenthCard > eighteenthCard)
                {
                    var newLeftCard = deck[17];
                    var newRightCard = deck[18];
                    deck[17] = newRightCard;
                    deck[18] = newLeftCard;
                }

                var nineteenthCard = deck[19];
                Console.WriteLine($"{eighteenthCard} and {nineteenthCard}");

                if (eighteenthCard > nineteenthCard)
                {
                    var newLeftCard = deck[18];
                    var newRightCard = deck[19];
                    deck[18] = newRightCard;
                    deck[19] = newLeftCard;
                }

            }

            Console.WriteLine(deck);


        }
    }
}

