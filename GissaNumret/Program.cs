namespace GissaNumret
{
    internal class Program
    {
        static void Main(string[] args)
        // Kristin Törnberg BUV26 Labb 4
        {
            Console.WriteLine("Välkommen!\nJag tänker på ett nummer. Kan du gissa vilket?\nDu får fem försök.");
            Random ran = new Random();
            int SecretNumber = ran.Next(1, 21);
            int attempts = 0;
            bool guessedCorrectly = false;

            while (attempts < 5)
            {
                Console.WriteLine($"Försök {attempts + 1}!\nGissa ett tal: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Felaktig inmatning! Du måste ange ett heltal.");
                    continue;
                }
                attempts++;
                if (CheckGuess(guess, SecretNumber))
                {
                    Console.WriteLine($"Wohoo! Du klarade utmaningen på {attempts} försök.");
                    guessedCorrectly = true;
                    break;
                }
                else if (guess < SecretNumber)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
            }
            if (!guessedCorrectly)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }
        }
        static bool CheckGuess(int guess, int secretNumber)
        {
            return guess == secretNumber;
        }

    }
}
