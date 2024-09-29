namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string keepGuessing = "j";

            while (keepGuessing == "j")
            {
                Console.WriteLine("Välj hur stort du vill gissa på");
                string inputMax = Console.ReadLine();
                int max = Convert.ToInt32(inputMax);

                Console.WriteLine("Välj hur många gissningar du får");
                string inputGuesses = Console.ReadLine();
                int guesses = Convert.ToInt32(inputGuesses);

                Random rnd = new Random();
                int numberToGuess = rnd.Next(1, max + 1);

                Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket?");

                for (int i = 0; i < guesses; i++)
                {
                    string input = Console.ReadLine();
                    int guess = Convert.ToInt32(input);

                    if (CheckGuess(guess, numberToGuess))
                    { 
                        break; // If guess is correct break the guess loop
                    }

                    if (i == guesses - 1) // Last guess, informs player that they lost
                    {
                        Console.WriteLine($"Tyvärr du lyckades inte gissa talet på {guesses} försök!");
                    }
                }

                Console.WriteLine("Vill du spela igen? (j/n)");
                keepGuessing = Console.ReadLine().ToLower();

            }
        }

        static bool CheckGuess(int guess, int numberToGuess)
        {
            if (guess == numberToGuess)
            {
                Console.WriteLine("Wohoo! Du gjorde det!");
                return true;
            }
            else if (guess < numberToGuess)
            {
                Console.WriteLine("Tyvärr du gissade för lågt!");
                return false;
            }
            else
            {
                // Randomizes response if guess was to high
                string[] responsesToHigh = [ "Tyvärr du gissade för högt!", "Haha! Det var för högt!", "Bra gissat men det var för högt!", "Försök igen men gissa lägre!" ];
                Random rnd = new Random();
                int rnd2 = rnd.Next(0, 4);
                Console.WriteLine(responsesToHigh[rnd2]);
                return false;
            }
        }
    }
}
