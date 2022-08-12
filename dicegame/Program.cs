// Let's practice some C#
// Completion time: 25 minutes; first C# project! After a day of learning the language.
using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerScore = 0;
            int enemyScore = 0;


            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Human against bot--who will win?! Press any key to find out!");

                Console.ReadKey();
                playerRandomNum = random.Next(1, 21);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("RNG pls");
                System.Threading.Thread.Sleep(1500);

                enemyRandomNum = random.Next(1, 21);
                Console.WriteLine("GoonBot rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerScore++;
                    Console.WriteLine("Grats! You win!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyScore++;
                    Console.WriteLine("Humans lose this round...");
                }
                else
                {
                    Console.WriteLine("A tie...? Really?");
                }

                Console.WriteLine("The current score is - You : " + playerScore + ". GoonBot : " + enemyScore + ".");
                Console.WriteLine();
            }

            if (playerScore  > enemyScore)
            {
                Console.WriteLine("Good guys win!");
            }
            else if (playerScore < enemyScore)
            {
                Console.WriteLine("Humans lose...");
            }
            else
            {
                Console.WriteLine("It's a tie! Suffer in endless torment! (Or just play again--yeah just play again.)");
            }

            Console.ReadKey();
        }




    }




}