//Question to points

int score = 0;

Console.WriteLine("Welcome to this quiz! Answer with \"yes\" or \"no\". Do you wish to continue?");
Console.ReadLine();

Console.WriteLine("Lungs are the largest internal organ in the human body."); 
string? firstQuestion = Console.ReadLine();
string firsQuestionStatus = "no"; 
CheckingMethod(firstQuestion, firsQuestionStatus);

Console.WriteLine(" The first song ever sung in the space was “Happy Birthday.”");  
string? secondQuestion = Console.ReadLine();
string secondQuestionStatus = "yes";
CheckingMethod(secondQuestion, secondQuestionStatus);

Console.WriteLine("A male canary tends to have a better singing voice than a female canary."); 
string? thirdQuestion = Console.ReadLine();
string thirdQuestionStatus = "yes";
CheckingMethod(thirdQuestion, thirdQuestionStatus);

Console.WriteLine("Dolphin is considered to be the fastest species in the ocean."); 
string? forthQuestion = Console.ReadLine();
string forthQuestionStatus = "no";
CheckingMethod(forthQuestion, thirdQuestionStatus);

Console.WriteLine("Mice have more bones than humans."); 
string? fifthQuestion = Console.ReadLine();
string fifthQuestionStatus = "yes";
CheckingMethod(fifthQuestion, fifthQuestionStatus);

void CheckingMethod(string userInputedWord, string questionStatus) //will check if the answer is correct or nah 
{
    if (userInputedWord.ToLower() == questionStatus)
    {
        Console.WriteLine("+1 good job");
        score++;
    }

    else if (userInputedWord.ToLower() != questionStatus)
    {
        Console.WriteLine("Wrong");
    }

    else
    {
        Console.WriteLine("invalid input , select yes or no ");
    }
}

var calculatingSCore = score >= 3 ? $"good job you scored {score}/3 whih is perfect" : $"well at least your tried your score is {score}";
Console.WriteLine(calculatingSCore);
