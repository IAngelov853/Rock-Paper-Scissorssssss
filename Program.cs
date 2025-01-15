using System;

class Program
{
    static void Main(string[] args)
    {
        string[] choices = { "Kamuk", "Hartiq", "Nojica" };
        Random random = new Random();
        string playAgain;

        do
        {
            Console.WriteLine("Izberi kamuk nojica ili hartiq:");
            string playerChoice = Console.ReadLine();
            string computerChoice = choices[random.Next(3)];

            Console.WriteLine($"Computer chose {computerChoice}.");

            if (playerChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ravenstvo");
            }
            else if ((playerChoice.Equals("Kamuk", StringComparison.OrdinalIgnoreCase) && computerChoice == "Nojica") ||
                     (playerChoice.Equals("Hartiq", StringComparison.OrdinalIgnoreCase) && computerChoice == "Kamuk") ||
                     (playerChoice.Equals("Nojica", StringComparison.OrdinalIgnoreCase) && computerChoice == "Hartiq"))
            {
                Console.WriteLine("Ti pechelish!");
            }
            else
            {
                Console.WriteLine("Izgubi!");
            }

            Console.WriteLine("Iskash li da igraesh pak? (da ili ne)");
            playAgain = Console.ReadLine();
        } while (playAgain.Equals("da", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Blagodarq che igrahte!");
    }
}
