

class Magic8Ball
{


    //This looks ugly af,but it works... find a way to fix it , maybe putting all of them in a single array and only using only 1 random instance
    string[] positiveAnswer = { "It is certain", "It is decidedly so", "Without a doubt", "Yes definitely", "You may rely on it", "As I see it, yes", "Mo st likely", "Outlook good", "Yes", "Signs point to yes" };
    string[] neutralAnswer = { "Try again", "Ask again later", " Better not tell you now", " Cannot predict now", " Concentrate and ask again" };
    string[] negativeAnswer = { "Don't count on it", "My reply is no", "My sources say no", "Outlook not so good,Very doubtful" };


    public static void Main()
    {

        Magic8Ball magicball = new Magic8Ball();
        Random randomNr = new Random();
        int answerList = randomNr.Next(0, 3);
        int randomPos = randomNr.Next(0, 11);
        int randomNeg = randomNr.Next(0, 6);//randomNr.Next(0,negativeAnswer.Length-1) might wrk too
        Console.WriteLine("Ask the mighty 8 ball your question:");
        string? userQuestion = Console.ReadLine();


        switch (answerList)
        {
            case 0:
                Console.WriteLine($"The mighty 8 ball says: {magicball.positiveAnswer[randomPos]}");
                break;

            case 1:
                Console.WriteLine($"The mighty 8 ball says: {magicball.neutralAnswer[randomNeg]}");
                break;

            default:
                Console.WriteLine($"The mighty 8 ball says: {magicball.negativeAnswer[randomNeg]}");
                break;

        }
    }


}
