using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Player
    {
        public string Name { get; set; }
        public int Runs { get; set; }

        public Player(string name)
        {
            Name = name;
            Runs = 0;
        }
    }

    public class Game
    {
        private Player user;
        private Player computer;
        private int totalOvers;
        private int ballsPerOver = 6;
        private Random random;

        public Game()
        {
            user = new Player("User");
            computer = new Player("Computer");
            random = new Random();
        }

        public void StartGame()
        {
            Console.Write("Enter no.of overs: ");
            totalOvers = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalOvers; i++)
            {
                Console.WriteLine($"\nOver {i + 1}:");
                UserBatting();
                ComputerBatting();
            }

            Winner();
        }

        private void UserBatting()
        {
            for (int ball = 1; ball <= ballsPerOver; ball++)
            {
                Console.Write($"Ball {ball}: Choose runs: ");
                int userRuns = int.Parse(Console.ReadLine());
                user.Runs += userRuns;
                Console.WriteLine($"User scored {userRuns} runs. Total runs: {user.Runs}");
            }
        }

        private void ComputerBatting()
        {
            for (int ball = 1; ball <= ballsPerOver; ball++)
            {
                int computerRuns = random.Next(0, 7);
                computer.Runs += computerRuns;
                Console.WriteLine($"Computer scored {computerRuns} runs. Total runs: {computer.Runs}");
            }
        }

        private void Winner()
        {
            Console.WriteLine("\nFinal Score:");
            Console.WriteLine($"{user.Name}: {user.Runs} runs");
            Console.WriteLine($"{computer.Name}: {computer.Runs} runs");

            if (user.Runs > computer.Runs)
            {
                Console.WriteLine("Congratulations user win");
            }
            else if (user.Runs < computer.Runs)
            {
                Console.WriteLine("Computer wins");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Game cricketGame = new Game();
            cricketGame.StartGame();
        }
    }
}

