bool found = true;
string[] listOfWord =["abstract","accounts","activation","afternoon","justice"];

Random random = new Random();
int randomSelection = random.Next(0,listOfWord.Length);

while (true)
{
  string userInput = Console.ReadLine();

        for (int i = 0; i < userInput.Length; i++)
         {
                              
               
                if (i < listOfWord[randomSelection].Length && userInput[i] == listOfWord[randomSelection][i])
                {
                        Console.Write($"{ listOfWord[randomSelection][i]}");
                }
                else
                {
                        Console.Write("_");
                }
        }      
}
