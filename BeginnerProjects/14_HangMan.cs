bool found = true;
string[] listOfWord =["abstract","accounts","activation","afternoon","justice"];

Random random = new Random();
int randomSelection = random.Next(0,listOfWord.Length);

//   string userInput = Console.ReadLine()!;

do
{
 Console.WriteLine("Enter your guess:");
 string userInput = Console.ReadLine()!;
    CheckingHangman(userInput,listOfWord);        
} while (found);
    
void CheckingHangman(string userInput,string[] listOfWord)
{
        found = false; // Reset found for this iteration
        bool correctGuess = false;

         for (int i = 0; i < userInput.Length; i++)
         {
                              
               
                if (i < listOfWord[randomSelection].Length && userInput[i] == listOfWord[randomSelection][i])
                {
                        Console.Write($"{listOfWord[randomSelection][i]}");
                        correctGuess = true;
                        
                        if(userInput == listOfWord[randomSelection])
                        {
                                Console.WriteLine("nice");
                                found = false; // End the game
                               break;
                               
                        }

        
                }
                else
                {
                        Console.Write("_ ");
                }
         }
      
}
   
