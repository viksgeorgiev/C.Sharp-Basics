

namespace BullsAndCows
{
    public static class HighScoreManger
    {
        private static int highScore = int.MaxValue;

        public static int GetHighScore()
        {
            if (highScore == int.MaxValue)
            {
                return 0;
            }
            else
            {
                return highScore;
            }         
        }

        public static void GetHighScore(int score)
        {
            if(score < highScore)
            {
                highScore = score;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool InGame = true;
            while (InGame)
            {
                InGame = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an optin:");
            Console.WriteLine("1) Play Bulls and Cows");
            Console.WriteLine("2) See Highest Score");
            Console.WriteLine("3) Exit");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                BullsAndCows();
                return true;
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("Highest score is:\n");
                Console.WriteLine(HighScoreManger.GetHighScore());
                Console.WriteLine("\n\nTo get back press Enter.");
                Console.ReadLine();
                MainMenu();
                return true;
            }
            else if (userInput == "3")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Press Enter");
                Console.ReadLine();
                MainMenu();
                return true;
            }
        }
     

        private static void HighestScore(int score)
        {
             

        }

        private static void BullsAndCows()
        {
            Console.Clear();
            Random random = new Random();
            List<int> numberGenerated = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    int randomNumber = random.Next(1, 10);
                    if (!numberGenerated.Contains(randomNumber))
                    {
                        numberGenerated.Add(randomNumber);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            int guessCounter = 0;
            string input;

            List<int> userNumber = new List<int>();

            while (true || input == "1111")
            {

                Console.WriteLine("Please input your Guess:");
                input = Console.ReadLine();

                
                if (input.Length != 4)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    continue;

                }

                for (int i = 0; i < 4; i++)
                {
                    userNumber.Add(int.Parse(input[i].ToString()));
                }

                if (input == "1111")
                {
                    Console.WriteLine("Number was:");
                    foreach (int i in numberGenerated)
                    {
                        Console.Write(i);
                    }
                    break;
                }

                int bulls = 0;
                int cows = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (!numberGenerated.Contains(userNumber[i]))
                    {
                        continue;
                    }
                    else if (numberGenerated[i] == userNumber[i])
                    {
                        bulls++;
                        continue;
                    }
                    else if (numberGenerated.Contains(userNumber[i]))
                    {
                        cows++;
                        continue;
                    }
                }

                guessCounter++;

                if (bulls != 4)
                {
                    Console.WriteLine($"Bulls: {bulls} - Cows: {cows}");
                    userNumber.Clear(); 
                }
                else if (bulls == 4)
                {
                    Console.WriteLine($"Congratulations you guessed {input} in {guessCounter} tries!");
                    HighScoreManger.GetHighScore(guessCounter);
                    Console.WriteLine($"Highest Score is: {HighScoreManger.GetHighScore()}");
                    Console.WriteLine("Press Enter.");
                    Console.ReadLine();
                    MainMenu();
                }
            }
        }
    }
}
