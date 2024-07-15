// See https://aka.ms/new-console-template for more information

string greeting = @"Welcome to the Amazing Guessing Game!";
Console.WriteLine(greeting);

int secretNumber = GenerateRandomNumber(1, 3);
Console.WriteLine("Please try to guess the secret number:");
int userGuess;

bool correctAnswerGuessed = false;
int maxGuesses = 4;
int guessCount = 0;

if (!int.TryParse(Console.ReadLine().Trim(), out userGuess))
{
    Console.WriteLine("Please enter valid input");
}
else if (secretNumber == userGuess)
{
    Console.WriteLine("Congrats! You guessed the secret number!");
}
else
{
    Console.WriteLine("You lose. You guessed wrong!");
}

static int GenerateRandomNumber(int min, int max)
{
    Random randomNumber = new Random();
    return randomNumber.Next(min, max + 1);
}
