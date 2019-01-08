using System;

namespace Lab40101aboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("About Andrew Quiz");

            bool answerOne = false;
            Q1(answerOne);

            int answerTwo = 33;
            Q2(answerTwo);

            string answerThree = "seattle";
            Q3(answerThree);

            bool answerFour = true;
            Q4(answerFour);

            string answerFive = "sunnyside";
            Q5(answerFive);

            Console.WriteLine("You've completed the quiz. Now you know about Andrew.");
            Console.ReadLine();

        }
        static bool Q1(bool answerOne)
        {
            Console.WriteLine("Question 1: True or False? Do I speak español?");
            string guessOne = Console.ReadLine();
            bool guessOneConverted = Convert.ToBoolean(guessOne.ToLower());

            if (answerOne == guessOneConverted)
            {
                Console.WriteLine("Correct! Although I'm mexican, I don't speak spanish fluently. I speak Spanglish.");
                return answerOne;
            }
            else
            {
                Console.WriteLine("Incorrect. Although I'm Mexican, I don't speak español fluently. I speak Spanglish.");
                answerOne = false;
                return answerOne;
            }

        }
        static int Q2(int answerTwo)
        {
            Console.WriteLine("Question 2: How old am I?");
            string guessTwo = Console.ReadLine();
            int guessTwoConverted = Convert.ToInt32(guessTwo);

            if (answerTwo == guessTwoConverted)
            {
                Console.WriteLine($"Correct! I am {answerTwo} years old.");
                return answerTwo;
            }
            else
            {
                Console.WriteLine($"Incorrect! I am {answerTwo} years old.");
                return answerTwo;
            }
        }
        static string Q3(string answerThree)
        {
            Console.WriteLine("Question 3: Where was I born?");
            string guessThree = Console.ReadLine();
            string guessThreeConverted = guessThree.ToLower();

            if (answerThree == guessThreeConverted)
            {
                Console.WriteLine($"Correct! I was born in {answerThree}.");
                return answerThree;
            }
            else
            {
                Console.WriteLine($"Incorrect! I was born in {answerThree}.");
                return answerThree;
            }
        }
        static bool Q4(bool answerFour)
        {
            Console.WriteLine("Question 4: True or False? I worked at kfc/taco bell?");
            string guessFour = Console.ReadLine();
            guessFour.ToLower();
            bool guessFourConverted = Convert.ToBoolean(guessFour);

            if (answerFour == guessFourConverted)
            {
                Console.WriteLine($"Correct! I worked at kfc/taco bell when I was 16 years old.");
                return answerFour;
            }
            else
            {
                Console.WriteLine($"Incorrect!  I worked at kfc/taco bell when I was 16 years old.");
                answerFour = true;
                return answerFour;
            }

        }
        static string Q5(string answerFive)
        {
            Console.WriteLine("Question 5: What city did I grow up in?");
            string guessFive = Console.ReadLine();
            string guessFiveConverted = guessFive.ToLower();

            if (answerFive == guessFiveConverted)
            {
                Console.WriteLine($"Correct! I was born in {answerFive}.");
                return answerFive;
            }
            else
            {
                Console.WriteLine($"Incorrect! I was born in {answerFive}.");
                return answerFive;
            }
        }
    }
}
