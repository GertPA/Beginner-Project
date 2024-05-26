
class MorseConverter //Main class Maybe we can seperate it ?
{
  string[] morseCode = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];
  char[] alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
  

 
  public static void Main()
  {
    MorseConverter morseconv = new MorseConverter();//used to call the class
    Console.WriteLine("You wanna convert : \n1.Text To Morse \n2.Morse to Text");
    int? userChoice = Convert.ToInt16(Console.ReadLine()); //get user input for the mode , converts it to int

    Console.WriteLine("what do you want to say?");
    string? userInput = Console.ReadLine();

    switch (userChoice)
    {
      case 1://Text To Morse
        foreach (char item in userInput.ToUpper()) //for each character in userInput , plus  transfroming it to upperCase
        {
          for (int i = 0; i < morseconv.alphabet.Length; i++) // "i"- will become the length of the array 
          {
            if (morseconv.alphabet[i] == item) //check if the letter is the same with the user character
                Console.Write(" " + morseconv.morseCode[i] + " "); // if it is i will become that character order , pasting it to the more array .
          }
        }
        break;

      case 2: //Morse To Text
        //  foreach (char item in userInput.ToUpper()) //only works for singe character , there must be a way to make it work with setences
        //  {
         for (int i = 0; i < morseconv.morseCode.Length; i++)
         {
          if(morseconv.morseCode[i] == userInput) 
           Console.WriteLine(morseconv.alphabet[i]);
         } 
        //  }
        break;

      default:
        Console.WriteLine("No input was provided.");
        break;
    }

  }
}

