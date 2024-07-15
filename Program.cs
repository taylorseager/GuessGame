// See https://aka.ms/new-console-template for more information

string greeting = @"Welcome to the Amazing Guessing Game!
Please try to guess the secret number.";
Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose a difficulty level:
                        0. Exit
                        1. Easy - 8 guesses
                        2. Medium - 6 guesses
                        3. Hard - 4 guesses
                        4. Cheater Mode");

    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Come back after your confidence is rebuilt.");
    }
    else if (choice == "1")
    {
        GuessingGame("easy");
    }
    else if (choice == "2")
    {
        GuessingGame("medium");
    }
    else if (choice == "3")
    {
        GuessingGame("hard");
    }
    else if (choice == "4")
    {
        GuessingGame("cheater");
    }
    else
    {
        Console.WriteLine("Invalid Choice. Try again!");
    }
}

void GuessingGame(string difficulty)
{
    int secretNumber = GenerateRandomNumber(1, 100);
    int userGuess;

    bool correctAnswerGuessed = false;
    int maxGuesses = 0;
    int guessCount = 0;

    if (difficulty == "hard")
    {
        maxGuesses = 4;
    }
    else if (difficulty == "medium")
    {
        maxGuesses = 6;
    }
    else if (difficulty == "easy")
    {
        maxGuesses = 8;
    }


        while (!correctAnswerGuessed && (difficulty == "cheater" || guessCount < maxGuesses))
    {
        int guessesLeft = maxGuesses - guessCount;
        if (difficulty == "cheater")
        {
            Console.WriteLine($"Your guess count: {guessCount++}");
            maxGuesses = maxGuesses+1;
        }
        else
        {
        Console.WriteLine(@$"Your guess count: {guessCount++}
        You have {guessesLeft} guesses remaining");
        }
       

        if (!int.TryParse(Console.ReadLine().Trim(), out userGuess))
        {
            Console.WriteLine("Please enter valid input");
        }
        else if (userGuess > secretNumber)
        {
            Console.WriteLine("Guess too high. Try again.");
        }
        else if (userGuess < secretNumber)
        {
            Console.WriteLine("Guess too low. Try again.");
        }
        else if (secretNumber == userGuess)
        {
            Console.WriteLine("Congrats! You guessed the right number!");
            correctAnswerGuessed = true;
        }
    }

    if (!correctAnswerGuessed && difficulty != "cheater")
    {
        Console.WriteLine("You lose. You guessed wrong!");
    }
}

static int GenerateRandomNumber(int min, int max)
{
    Random randomNumber = new Random();
    return randomNumber.Next(min, max + 1);
}
