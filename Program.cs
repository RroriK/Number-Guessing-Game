namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome! Please secect an option");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Exit");

                byte usAns = byte.Parse(Console.ReadLine());

                switch (usAns)
                {
                    case 1:
                        StartGame();
                        break;
                    case 2:
                        Console.WriteLine("Have a good day!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void StartGame()
        {
            Random random = new Random();
            byte attempts = 5;
            int rndNum = random.Next(0, 101);

            while (true)
            {
                if(attempts == 0)
                {
                    Console.WriteLine("You lose!");
                    Main();
                }

                Console.WriteLine($"{attempts} attempts left!");
                Console.WriteLine("Enter number");
                int usGus = int.Parse(Console.ReadLine());

                if(usGus > rndNum)
                {
                    Console.WriteLine("Your number is bigger!");
                    attempts--;
                }

                else if (usGus < rndNum)
                {
                    Console.WriteLine("Your number is lessfs!");
                    attempts--;
                }

                else if(usGus == rndNum)
                {
                    Console.WriteLine("You win!");
                    Main();
                }
            }
        }
    }
}
