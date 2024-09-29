namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj hur stort du vill gissa på");
            string inputMax = Console.ReadLine();
            int max = Int32.Parse(inputMax);

            Console.WriteLine("Välj hur många gissningar du får");
            string inputGuesses = Console.ReadLine();
            int guesses = Int32.Parse(inputGuesses);

            Random rnd = new Random();
            int rnd1 = rnd.Next(1, max + 1);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket?");

            for (int i = 0; i < guesses; i++)
            {
                string input = Console.ReadLine();
                int guess = Int32.Parse(input);

                if (CheckGuess(guess, rnd1))
                {
                    break;
                }

                if (i == guesses - 1)
                {
                    Console.WriteLine($"Tyvärr du lyckades inte gissa talet på {guesses} försök!");
                }
            }

            static bool CheckGuess(int guess, int rnd1)
            {
                if (guess == rnd1)
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                    return true;
                }
                else if (guess < rnd1)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                    return false;
                }
                else
                {
                    string[] responsesToHigh = new string[] { "Tyvärr du gissade för högt!", "Haha! Det var för högt!", "Bra gissat men det var för högt!", "Försök igen men gissa lägre!" };
                    Random rnd = new Random();
                    int rnd2 = rnd.Next(0, 4);
                    Console.WriteLine(responsesToHigh[rnd2]);
                    return false;
                }
            }
        }
    }
}
