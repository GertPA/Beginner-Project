using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;


Arrow thisShit = new Arrow();
Console.WriteLine(thisShit);


public enum Arrowheads : int
{
    steel = 10,
    wood = 3,
    obsidian = 5
}

public enum Fleching : int
{
    plastic = 10,
    TurkeyFeathers = 5,
    GooseFeathers = 3
}
class Arrow
{
    public int shaft;
    bool reask = true;
    public int userShaftChoice;


    public Arrow()
    {
        Console.WriteLine("\tHellow and welcome to the shop \n\tpress enter to continue");//rewrite - priority D
        Console.ReadLine();

        Console.WriteLine("pick your arrow heads : \n1.Steel \n2.Wood \n3.Obsidian"); //can you use enums here ? - ↓ 
        int userArrowHeadChoice = Convert.ToInt16(Console.ReadLine());
        userSwitchChoice(userArrowHeadChoice, Arrowheads.steel, Arrowheads.wood, Arrowheads.obsidian);



        while (reask)
        {
            Console.WriteLine("pick your shaft size (min= 60 , max = 100)");   //rewrite - priority D
            int userShaftChoice = Convert.ToInt16(Console.ReadLine());
            if (userShaftChoice >= 60 && userShaftChoice <= 100)
            {

                Console.WriteLine($"Total price: {(float)ShaftCalculating(userShaftChoice)}");
                reask = false;
            }
            else
            {
                Console.WriteLine("Pls pick something between 60 and 100"); //rewrite - priority D

            }

        }
        ;

        Console.WriteLine("pick your arrow heads : \n1.Plastic \n2.Turkey Feathers \n3.Goose Feathers");
        int userFlechingChoice = Convert.ToInt16(Console.ReadLine());
    }

    public void userSwitchChoice(int userinput, int item1, int item2, int item3)
    {
        switch (userinput)
        {
            case 1:
                { int picked = item1; }
                break;

            case 2:
                { int picked = item2; }
                break;

            case 3:
                { int picked = item3; }
                break;
        }
    }


    public double ShaftCalculating(double userChoice)
    {
        double defaultSize = 60;
        double cosetDiff = 0.05;

        if (userChoice == null)
        {
            double finalCost = defaultSize * cosetDiff;
            return finalCost;
        }
        else
        {
            double finalCost = userChoice * cosetDiff;
            return finalCost;
        }
    }

}
