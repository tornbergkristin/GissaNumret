namespace GissaNumret
{
    internal class Program
    {
        static void Main(string[] args)
        // Kristin Törnberg BUV26 Labb 4
        {
            Console.WriteLine("Välkommen!\nJag tänker på ett nummer. Kan du gissa vilket?\nDu får fem försök.");
            Random ran = new Random();
            int SecretNumber = ran.Next(1, 21); //Setting a random number between 1-20, 21 = 20.
            int attempts = 0;
            bool guessedCorrectly = false;

            while (attempts < 5) //Counting is 0-4 = 5 attempts
            {
                Console.WriteLine($"Försök {attempts + 1}!\nGissa ett tal: "); //To let the player know on what attempt they're on.
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Felaktig inmatning! Du måste ange ett heltal.");
                    continue;
                }
                attempts++; //Adding to every attempt made att guessing the right number.
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
        static bool CheckGuess(int guess, int secretNumber) //When the bool is true or the person is out of attempts, this returns how many attempts before the game ended.
        {
            return guess == secretNumber;
        }

    }
}
