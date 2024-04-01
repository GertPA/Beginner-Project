//Magic 8 ball

Random randomNr = new Random();
int answerList = randomNr.Next(0,3);
int randomPos = randomNr.Next(0, 11);
int randomNeg = randomNr.Next(0,6);//randomNr.Next(0,negativeAnswer.Length-1) might wrk too


//This looks ugly af,but it works... find a way to fix it 
string[] positiveAnswer={"It is certain", "It is decidedly so","Without a doubt","Yes definitely","You may rely on it", "As I see it, yes", "Mo st likely","Outlook good","Yes","Signs point to yes" };
string[] neutralAnswer ={ "Try again","Ask again later"," Better not tell you now"," Cannot predict now" ," Concentrate and ask again"};
string[] negativeAnswer ={"Don't count on it","My reply is no","My sources say no","Outlook not so good,Very doubtful"};


Console.WriteLine("Ask the mighty 8 ball your question:");

string? userQuestion = Console.ReadLine();


switch(answerList)
{
    case 0:
    Console.WriteLine($"The mighty 8 ball says: {positiveAnswer[randomPos]}");
    break;

   case 1:
   Console.WriteLine($"The mighty 8 ball says: {neutralAnswer[randomNeg]}");
   break;   

   default:
   Console.WriteLine($"The mighty 8 ball says: {negativeAnswer[randomNeg]}");
   break;

}


