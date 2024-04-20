//Guess the number 1-100, hints when its above or below your guess\

Random randomNumber = new Random();
int randomNr = randomNumber.Next(1, 101);
bool correctAwnser = true;
int numberOfLives = 5;
int numberOfGuesses = 0;
int higherNumber = 0;
int lowerNumber = 0;
Console.WriteLine($"Hello and welcome to the guessing game \n Pick your game mode:");
Console.WriteLine($"[1] - Normal Mode\n[2] - Survival Mode");


int userPicked = Convert.ToInt32(Console.ReadLine());
if (userPicked == 1) // Normal Mode
{
    while (correctAwnser == true)
    {
        Console.WriteLine("Guess a number between 1 and 100");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (randomNr > userInput)
        {
            Console.WriteLine("Its higher");
            numberOfGuesses++;
            higherNumber++;
            correctAwnser = true;
        }
        else if (randomNr < userInput)
        {
            Console.WriteLine("its lower");
            lowerNumber++;
            numberOfGuesses++;
            correctAwnser = true;
        }
        else if (randomNr == userInput)
        {
            Console.WriteLine($"Good job you found it, {randomNr} was the secret number");
            correctAwnser = false;
        }
    }
}
else //Survival Mode
{
    while (correctAwnser == true)
    {

        Console.WriteLine("Guess a number between 1 and 100");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (randomNr > userInput && numberOfLives > 0)
        {
            Console.WriteLine("Its higher");
            numberOfGuesses++;
            higherNumber++;
            numberOfLives--;
            correctAwnser = true;
        }
        else if (randomNr < userInput && numberOfLives > 0)
        {
            Console.WriteLine("its lower");
            lowerNumber++;
            numberOfGuesses++;
            numberOfLives--;
            correctAwnser = true;
        }
        else if (randomNr == userInput)
        {
            Console.WriteLine($"Good job you found it, {randomNr} was the secret number");
            correctAwnser = false;
        }
        else if (numberOfLives == 0) 
        {
            Console.WriteLine($"Game over! You ran out of lives.");
            correctAwnser = true;
            break;
        }

    }
}

Console.WriteLine($"Total Number of guesses is: {numberOfGuesses} , with {higherNumber} guesses being higher numbers and {lowerNumber} guesses being lower numbers");


