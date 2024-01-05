namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Number Guesser!");
            Random computer = new Random();
            int computerAnswer = computer.Next(1, 99);
            bool isGuessed = false;
            int guesses = 1;

            while (!isGuessed)
            {
                Console.Write("Enter a number between 1 and 99: ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (guesses == 5)
                {
                    Console.WriteLine("You lose!");
                    System.Environment.Exit(1);
                } 
                else
                {
                    if (answer > computerAnswer)
                    {
                        Console.WriteLine($"Computer number is lower than {answer}");
                        Console.WriteLine($"Guesses left: {5 - guesses }");
                        guesses++;
                    }
                    else if (answer < computerAnswer)
                    {
                        Console.WriteLine($"Computer number is higher than {answer}");
                        Console.WriteLine($"Guesses left: {5 - guesses}");
                        guesses++;
                    }
                    else if (answer == computerAnswer)
                    {
                        Console.WriteLine($"You guessed the correct answer of {computerAnswer}");
                        isGuessed = true;
                    }
                }

            }

            Console.WriteLine("Well done!");
            System.Environment.Exit(1);

        }
    }
}
