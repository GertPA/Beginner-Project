//An attempt to creating an hangman game

string[] listOfWord =["abstract","accounts","activation","afternoon","justice"];

Random random = new Random();
int randomSelection = random.Next(0,listOfWord.Length);

string userInput = "abstract";

        for (int i = 0; i < userInput.Length; i++)
        {
                if (i < listOfWord[randomSelection].Length && userInput[i] == listOfWord[randomSelection][i])
                {
                        Console.WriteLine($"Character '{userInput[i]}' at position {i} works.");
                }
                else
                {
                        Console.WriteLine($"Character '{userInput[i]}' at position {i} doesn't work.");
                }
        }
