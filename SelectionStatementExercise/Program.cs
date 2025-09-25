namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 11);
            int userInput = 0;

            while (userInput != favNumber)
            {
                Console.WriteLine("Guess my favorite number between 1 and 10:");
                userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine($"Too high!\nYour guess: {userInput}");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine($"Too low! Your guess: {userInput}");
                }
                else 
                {
                    Console.WriteLine($"You guessed it! The favorite number was {userInput}!");
                }  
            }
            
        }
    }
}
