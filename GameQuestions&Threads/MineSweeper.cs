using System;

namespace mineSweeper
{
    class Minesweeper
    {
        static char[,] grid;
        static bool[,] mines;
        static bool[,] revealed;
        static int size = 5;
        static int minesCount = 5;
        static int score = 0;

        public static void Main()
        {
            InitializeGame();
            PlayGame();
        }

        static void InitializeGame()
        {
            grid = new char[size, size];
            mines = new bool[size, size];
            revealed = new bool[size, size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = '*';
                    mines[i, j] = false;
                    revealed[i, j] = false;
                }
            }

            int placedMines = 0;
            while (placedMines < minesCount)
            {
                int row = random.Next(size);
                int col = random.Next(size);

                if (!mines[row, col])
                {
                    mines[row, col] = true;
                    placedMines++;
                }
            }
        }

        static void PlayGame()
        {
            while (true)
            {
                PrintGrid();
                Console.Write("Enter row index (0-4): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter column index (0-4): ");
                int col = int.Parse(Console.ReadLine());

                if (row < 0 || row >= size || col < 0 || col >= size)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (mines[row, col])
                {
                    Console.WriteLine("\nYou hit a mine. Game Over.");
                    break;
                }
                else if (revealed[row, col])
                {
                    Console.WriteLine("revealed.");
                }
                else
                {
                    RevealCell(row, col);
                    Console.WriteLine("\nYou are safe, keep going.");
                    if (CheckWin())
                    {
                        Console.WriteLine("Congratulations");
                        break;
                    }
                }
            }
        }

        static void RevealCell(int row, int col)
        {
            revealed[row, col] = true;

            int adjacentMines = CountAdjacentMines(row, col);
            grid[row, col] = (char)(adjacentMines + '0');
            score++;

            Console.ForegroundColor = ConsoleColor.Red;
            grid[row, col] = (char)(score + '0');
            Console.Write($"Points: {grid[row, col]} ");
            Console.ResetColor();
        }

        static int CountAdjacentMines(int row, int col)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < size && j >= 0 && j < size && mines[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static bool CheckWin()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (!mines[i, j] && !revealed[i, j])
                        return false;
                }
            }
            return true;
        }

        static void PrintGrid()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (revealed[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(grid[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(grid[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
