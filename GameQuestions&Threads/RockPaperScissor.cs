using System;

namespace ConsoleApp3
{
    public enum Elements
    {
        Rock = 1,
        Paper = 2,
        Scissor = 3,
    }

    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public virtual Elements GetMove()
        {
            return Elements.Rock;
        }
    }

    class User : Player
    {
        public User(string name) : base(name, 0) { }

        public override Elements GetMove()
        {
            Console.Write("Enter move:");
            string userMove = Console.ReadLine().Trim().ToLower();

            if (userMove == "rock")
                return Elements.Rock;
            else if (userMove == "paper")
                return Elements.Paper;
            else if (userMove == "scissor")
                return Elements.Scissor;
            else
                throw new ArgumentException("Invalid input");
        }
    }

    class UserSystem : Player
    {
        public static Random random = new Random();

        public UserSystem(string name) : base(name, 0) { }

        public override Elements GetMove()
        {
            return (Elements)random.Next(1, 4);
        }
    }

    public class Game
    {
        private Player user;
        private Player system;
        private const int WinningScore = 10;

        public Game()
        {
            user = new User("User");
            system = new UserSystem("System");
        }

        public void GamePlay()
        {
            while (user.Score < WinningScore && system.Score < WinningScore)
            {
                try
                {
                    Elements userMove = user.GetMove();
                    Elements systemMove = system.GetMove();

                    Console.WriteLine($"User choice: {userMove}");
                    Console.WriteLine($"System choice: {systemMove}");

                    int result = PointsAwarded(userMove, systemMove);
                    if (result == 1)
                    {
                        user.Score++;
                        Console.WriteLine("User wins this round");
                    }
                    else if (result == -1)
                    {
                        system.Score++;
                        Console.WriteLine("System wins this round");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!");
                    }

                    Console.WriteLine($"Score - User: {user.Score} | System: {system.Score}\n");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(user.Score == WinningScore ? "Congratulations! You win the game!" : "System wins the game. Better luck next time!");
        }

        private int PointsAwarded(Elements userMove, Elements systemMove)
        {
            if (userMove == systemMove) return 0;

            if ((userMove == Elements.Rock && systemMove == Elements.Scissor) ||
                (userMove == Elements.Paper && systemMove == Elements.Rock) ||
                (userMove == Elements.Scissor && systemMove == Elements.Paper))
            {
                return 1;
            }
            return -1;
        }
    }

    internal class program
    {
        static void Main()
        {
            Game game = new Game();
            game.GamePlay();
        }
    }
}
