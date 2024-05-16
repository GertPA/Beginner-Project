class GuessTheNumber
{
  public Random randomNumber = new Random();
  private int randomNr;
  private bool correctAwnser = true;
  private int numberOfLives { get; set; }
  private int numberOfGuesses { get; set; }
  private int higherNumber { get; set; }
  private int lowerNumber { get; set; }
  public GuessTheNumber(int _numberOfLives, int _numberOfGuesses, int _higherNumber, int _lowerNumber)
  {
    randomNr = randomNumber.Next(1, 101);

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
          _numberOfGuesses++;
          _higherNumber++;
          correctAwnser = true;
        }
        else if (randomNr < userInput)
        {
          Console.WriteLine("its lower");
          _lowerNumber++;
          _numberOfGuesses++;
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

        if (randomNr > userInput && _numberOfLives > 0)
        {
          Console.WriteLine("Its higher");
          _numberOfGuesses++;
          _higherNumber++;
          _numberOfLives--;
          correctAwnser = true;
        }
        else if (randomNr < userInput && _numberOfLives > 0)
        {
          Console.WriteLine("its lower");
          _lowerNumber++;
          _numberOfGuesses++;
          _numberOfLives--;
          correctAwnser = true;
        }
        else if (randomNr == userInput)
        {
          Console.WriteLine($"Good job you found it, {randomNr} was the secret number");
          correctAwnser = false;
        }
        else if (_numberOfLives == 0)
        {
          Console.WriteLine($"Game over! You ran out of lives.");
          correctAwnser = true;
          break;
        }

      }
    }
    Console.WriteLine($"Total Number of guesses is: {_numberOfGuesses} , with {_higherNumber} guesses being higher numbers and {_lowerNumber} guesses being lower numbers");
  }

}

class Program
{
  public static void Main()
  {
    GuessTheNumber run = new GuessTheNumber(5, 0, 0, 0);
  }
}
