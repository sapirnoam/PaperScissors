using System;

namespace PaperScissors
{
    class RockPaper
    {
        int AI;
        int User;

        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play Rock Paper Scissors? \n 1 - Yes \n 2 - no, Quit");

            int choosement = int.Parse(Console.ReadLine());
            if (choosement == 2)
            {
                Environment.Exit(1);
            }
            else
            {
                RockPaper rockPaper = new RockPaper();
                rockPaper.Battle();
            }
        }

        void Battle()
        {
            if (AI >= 3 || User >= 3)
            {
                Winner();
            }
            Console.WriteLine("\n------------------");

            Random rnd = new Random();
            int AIChoosement = rnd.Next(1, 4);
            Console.WriteLine("Rock, Paper Scissors!");
            Console.WriteLine("1 - Rock");
            Console.WriteLine("2 - Paper");
            Console.WriteLine("3 - Scissors");
            int usrChoosement = Convert.ToInt32(Console.ReadLine());

            if (usrChoosement != 0 && usrChoosement <= 3)
            {
                Console.WriteLine("------------------");
                if (usrChoosement == 1 && AIChoosement == 2)
                {
                    Console.WriteLine("AI Won this round, AI Choosed: " + AIChoosement + "\n Press any key for the next round.");
                    Console.ReadKey();
                    AI++;
                    Battle();
                }
                else if (usrChoosement == 2 && AIChoosement == 1)
                {
                    Console.WriteLine("You Won this round, AI Choosed: " + AIChoosement + "\n Press any key for the next round.");
                    Console.ReadKey();
                    Battle();
                }

                if (usrChoosement == 1 && AIChoosement == 3)
                {
                    Console.WriteLine("You Won this round, AI Choosed: " + AIChoosement + "\n Press any key for the next round.");
                    Console.ReadKey();
                    User++;
                    Battle();

                }
                else if (usrChoosement == 3 && AIChoosement == 1)
                {
                    Console.WriteLine("AI Won this round, AI Choosed: " + AIChoosement + "\n Press any key for the next round.");
                    Console.ReadKey();
                    AI++;
                    Battle();
                }

                if (usrChoosement == 2 && AIChoosement == 3)
                {
                    Console.WriteLine("AI Won this round, AI Choosed: " + AIChoosement + "\n Press any key for the next round.");
                    Console.ReadKey();
                    AI++;
                    Battle();
                }
                else if (usrChoosement == 3 && AIChoosement == 2)
                {
                    Console.WriteLine("You Won this round, AI Choosed: " + AIChoosement + "\n Press any key for the next round.");
                    Console.ReadKey();
                    User++;
                    Battle();
                }

                if (usrChoosement == AIChoosement)
                {
                    Console.WriteLine("DRAW! \n Press any key for the next round.");
                    Console.ReadKey();
                    Battle();
                }
            }
            else
            {
                Console.WriteLine("Invaild Input!");
                Battle();
            }
        }

        void Winner()
        {
            Console.WriteLine("------------------");
            if (AI >= 3 && User < 3)
                Console.WriteLine("AI won!");
            else if (User >= 3 && AI < 3)
                Console.WriteLine("You won! \n");
            Console.WriteLine("AI Points: " + AI);
            Console.WriteLine("Your Points: " + User);
            Console.WriteLine("---------------- \n");
            Console.WriteLine("Play again?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No, Quit");

            int choosement = int.Parse(Console.ReadLine());
            if (choosement == 2)
            {
                Environment.Exit(1);
            }
            else
            {
                AI = 0;
                User = 0;
                Console.Clear();
                Battle();
            }
        }
    }
}
