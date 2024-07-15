// See https://aka.ms/new-console-template for more information

string greeting = @"Welcome to the Amazing Guessing Game!
You get 4 guesses! Choose wisely.";
Console.WriteLine(greeting);

int secretNumber = GenerateRandomNumber(1, 10);
int userGuess;

bool correctAnswerGuessed = false;
int maxGuesses = 4;
int guessCount = 0;


while (!correctAnswerGuessed && guessCount < maxGuesses)
{
    int guessesLeft = maxGuesses - guessCount;
    Console.WriteLine(@$"Please try to guess the secret number.
    Your guess count: {guessCount++}
    You have {guessesLeft} guessess remaining");

    if (!int.TryParse(Console.ReadLine().Trim(), out userGuess))
    {
        Console.WriteLine("Please enter valid input");
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Guess too high. Try again.");
    }
    else if (userGuess < secretNumber && guessesLeft > 1)
    {
        Console.WriteLine("Guess too low. Try again.");
    }
    else if (secretNumber == userGuess)
    {
        Console.WriteLine("Congrats! You guessed the right number!");
        correctAnswerGuessed = true;
    }
    else
    {
        Console.WriteLine("You lose. You guessed wrong!");
        correctAnswerGuessed = false;

    }
}


static int GenerateRandomNumber(int min, int max)
{
    Random randomNumber = new Random();
    return randomNumber.Next(min, max + 1);
}
