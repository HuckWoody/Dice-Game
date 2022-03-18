using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.WriteLine();

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player winds this round!");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else 
                {
                    Console.WriteLine("Draw!");
                }
                
                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > enemyPoints) 
            {
                Console.WriteLine("You win this game!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose this game :(");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();
        }
    }
}
