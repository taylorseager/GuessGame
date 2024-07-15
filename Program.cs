﻿// See https://aka.ms/new-console-template for more information

string greeting = @"Welcome to the Amazing Guessing Game!
You get 4 guesses! Choose wisely.";
Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose a difficulty level:
                        0. Exit
                        1. Easy - 8 guesses
                        2. Medium - 6 guesses
                        3. Hard - 4 guesses");

    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Come back after your confidence is rebuilt.");
    }
    else if (choice == "1")
    {
        EasyDifficulty();
    }
    else if (choice == "2")
    {
        MediumDifficulty();
    }
    else if (choice == "3")
    {
        HardDifficulty();
    }
    else
    {
        Console.WriteLine("Invalid Choice. Try again!");
    }
}

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

void EasyDifficulty()
{
    Console.WriteLine();
}

void MediumDifficulty()
{
    Console.WriteLine();
}

void HardDifficulty()
{
    Console.WriteLine();
}


static int GenerateRandomNumber(int min, int max)
{
    Random randomNumber = new Random();
    return randomNumber.Next(min, max + 1);
}
