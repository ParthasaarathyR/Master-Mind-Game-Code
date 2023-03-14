using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MasterMind_Game_Code_Console
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void CodeMakerInput(int[] MakerArray)
        {
            string Makername;
            int MakerInput;

            Console.Clear();
            Console.WriteLine("Welcome To The Master-Mind Game");
            Console.WriteLine();
            Console.Write("Please Enter Your Name Code Maker : ");
            Makername = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome {0}. Lets first fix the code for the Code Breaker... ", Makername);
            Console.WriteLine();
            Console.WriteLine("Enter the Code Numbers");
            Console.WriteLine();

            for (int i = 0; i < MakerArray.Length; i++)
            {
                Console.Write("Digit {0}: ", (i + 1));
                MakerInput = int.Parse(Console.ReadLine());
                MakerArray[i] = MakerInput;
            }
            Console.WriteLine();
            Console.Write("Your guess: ");
            for (int i = 0; i < MakerArray.Length; i++)
            {
                Console.Write(MakerArray[i] + " ");
            }
            Thread.Sleep(3000);
        }

        public static int GetGameDifficulty(int difficultyLevel)
        {
            int difficulty = 0;

            do
            {
                try
                {
                    Console.Write("Choose a difficulty level (1=hard, 2=medium, 3=easy): ");
                    difficulty = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Incorrect entry: Please re-enter.");
                }
            } while ((difficulty < 1) || (difficulty > 3));

            return difficulty;
        }

        public static int[] GetUserGuess()
        {
            int number = 0;
            int[] BreakerInput = new int[4];
            for (int i = 0; i < BreakerInput.Length; i++)
            {
                Console.Write("Digit {0}: ", (i + 1));
                number = int.Parse(Console.ReadLine());
                BreakerInput[i] = number;
            }
            Console.WriteLine();
            Console.Write("Your guess: ");
            for (int i = 0; i < BreakerInput.Length; i++)
            {
                Console.Write(BreakerInput[i] + " ");
            }
            Console.WriteLine();
            return BreakerInput;
        }

        public static int CountHits(int[] MakerArray, int[] BreakerArray, int attempts)
        {
            int hit = 0;
            int miss = 0;
            int hits = 0;

            for (int i = 0; i < MakerArray.Length; i++)
            {
                if (MakerArray[i] == BreakerArray[i])
                {
                    hit = hit + 1;
                    hits = hit;
                }
                else if (MakerArray[0] == BreakerArray[i] || MakerArray[1] == BreakerArray[i] || MakerArray[2] == BreakerArray[i] || MakerArray[3] == BreakerArray[i])
                {
                    miss = miss + 1;
                }
            }
            Console.WriteLine("Results: {0} Red Pin and {1} White Pin", hits, miss);
            return hits;
        }
    }
}
