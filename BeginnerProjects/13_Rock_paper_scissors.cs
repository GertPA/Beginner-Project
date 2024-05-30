using System.Diagnostics;

class RockPaperScissor
{
    enum computerChoice : int { rock = 0, paper = 1, scissor = 2 }
    Random randomz = new Random();
    public string _userInput;
    public static void Main()
    {
        Console.WriteLine("Pick rock , Paper, Scissors");
        string userChoice = Console.ReadLine()!;
        RockPaperScissor test = new RockPaperScissor(userChoice.ToLower());
    }
    
    public RockPaperScissor(string userInput)
    {
        int random = randomz.Next(0, 3);
       
        _userInput = userInput;
      
Console.WriteLine($"you have picked {userInput} and the computer has picked {(computerChoice)random} ");
//You lose
if (userInput == "rock" && (int)(computerChoice)random == 1 )Console.WriteLine("You Lost");
else if (userInput == "paper" && (int)(computerChoice)random == 2 ) Console.WriteLine("You Lost");
else if(userInput == "scissor" && (int)(computerChoice)random == 0 ) Console.WriteLine("You Lost");

//You Win
else if (userInput == "rock" && (int)(computerChoice)random == 2 ) Console.WriteLine("You Win");
else if (userInput == "paper" && (int)(computerChoice)random == 0 ) Console.WriteLine("You Win");
else if(userInput == "scissor" && (int)(computerChoice)random == 1 ) Console.WriteLine("You Win");

//Draw
else if (userInput == "rock" && (int)(computerChoice)random == 0 ) Console.WriteLine("Its a Draw");
else if (userInput == "paper" && (int)(computerChoice)random == 1 ) Console.WriteLine("Its a Draw");
else if(userInput == "scissor" && (int)(computerChoice)random == 2 ) Console.WriteLine("Its a Draw");
    }
}


 
