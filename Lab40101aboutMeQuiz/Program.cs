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

            string answerThree = "kj";
            Q3(answerThree);

            bool answerFour = false;
            Q4(answerFour);

            int answerFive = 2006;
            Q5(answerFive);

            Console.WriteLine("The game is complete! Thank you for playing");
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
                Console.WriteLine($"Incorrect! I am {answerTwo} years young.");
                return answerTwo;
            }
        }
        static string Q3(string answer3)
        {
            Console.WriteLine("Question 3: What was my nickname growing up? (Hint: 2 Letter Nickname)");
            string guess3 = Console.ReadLine();
            string guess3L = guess3.ToLower();
            if (answer3 == guess3L)
            {
                Console.WriteLine($"Correct! My nickname growing up was {answer3}!");
                return answer3;
            }
            else
            {
                Console.WriteLine($"Incorrect! My nickname growing up was {answer3}! Not very original I know");
                return answer3;
            }
        }
        static bool Q4(bool answer4)
        {
            Console.WriteLine("Question 1: True or False? I served in the Navy?");
            string guess4 = Console.ReadLine();
            guess4.ToLower();
            bool guessB2 = Convert.ToBoolean(guess4);

            if (answer4 == guessB2)
            {
                Console.WriteLine("Correct guess. I did not serve in the Navy! I served in the Army from '07-'13. Beat Navy!");
                return answer4;
            }
            else
            {
                Console.WriteLine("Incorrect guess.  I served in the Army from 07'-'13. Go Army, Beat Navy!");
                answer4 = true;
                return answer4;
            }

        }
        static int Q5(int answer5)
        {
            Console.WriteLine("Question 5: What year did I graduate high school? (4 digit year)?");
            string guess2 = Console.ReadLine();
            int guessI2 = Convert.ToInt32(guess2);

            if (answer5 == guessI2)
            {
                Console.WriteLine($"Correct! I graduated from high school in {answer5}.");
                return answer5;
            }
            else
            {
                Console.WriteLine($"Incorrect! I graduated from high school in {answer5}.");
                return answer5;
            }
        }
    }
}
