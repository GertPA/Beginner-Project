//THIS TOOK SO MUCH GOD DAMN  TIME TO FIGURE IT OUT , ITS SO FUCKING SIMPLE YET I COULNT FIGURE IT OUT WITHOUT HELP , I AINT CUT OUT FOR THIS 

class MorseConverter
{
  string[] morseCode = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];
  char[] alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];


  public static void Main()
  {
    MorseConverter morseconv = new MorseConverter();
    Console.WriteLine("what do you want to say?");
    string? userInput = Console.ReadLine();

    if (userInput != null) //so we can remove that damn annoying null reference warning
    {
      foreach (char item in userInput.ToUpper())
      {
        for (int i = 0; i < morseconv.alphabet.Length; i++)
        {
          if (morseconv.alphabet[i] == item)
          {
            Console.Write(" " + morseconv.morseCode[i] + " ");

          }
        }
      }
    }
    else
    {
      Console.WriteLine("No input was provided.");
    }

  }


  void Calculate(char[] alp, string[] morse, char it)
  {

    for (int i = 0; i < alphabet.Length; i++)
    {
      if (alphabet[i] == it)
      {
        Console.Write(" " + morseCode[i] + " ");

      }
    }

  }


}
