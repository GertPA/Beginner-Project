using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

//this will run it 
Arrow thisThing = new Arrow();
Console.WriteLine(thisThing);


public enum Arrowheads : int { steel = 10, wood = 3, obsidian = 5 }

public enum Fleching : int { plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3 }

class Arrow
{
    public int shaft;
    bool reask = true;
    public int userShaftChoice;


    public Arrow()
    {
        Console.WriteLine("\tHellow and welcome to the shop \n\tpress enter to continue");
        Console.ReadLine();

        Console.WriteLine("pick your arrow heads : \n1.Steel \n2.Wood \n3.Obsidian");
        int userArrowHeadChoice = Convert.ToInt16(Console.ReadLine());
        userSwitchChoice(userArrowHeadChoice, (int)Arrowheads.steel, (int)Arrowheads.wood, (int)Arrowheads.obsidian);



        while (reask)
        {
            Console.WriteLine("Please select your shaft size (minimum: 60, maximum: 100).");
            int userShaftChoice = Convert.ToInt16(Console.ReadLine());
            if (userShaftChoice >= 60 && userShaftChoice <= 100)
            {

                Console.WriteLine($"Total price: {(float)ShaftCalculating(userShaftChoice)}");
                reask = false;
            }
            else
            {
                Console.WriteLine("Invalid input"); 

            }

        }
        ;

        Console.WriteLine("pick your arrow heads : \n1.Plastic \n2.Turkey Feathers \n3.Goose Feathers");
        int userFlechingChoice = Convert.ToInt16(Console.ReadLine());
        userSwitchChoice(userFlechingChoice, (int)Fleching.plastic, (int)Fleching.TurkeyFeathers, (int)Fleching.GooseFeathers);



        int arrowTotal = userSwitchChoice(userArrowHeadChoice, (int)Arrowheads.steel, (int)Arrowheads.wood, (int)Arrowheads.obsidian);
        int flechingTotal = userSwitchChoice(userFlechingChoice, (int)Fleching.plastic, (int)Fleching.TurkeyFeathers, (int)Fleching.GooseFeathers);
        float shaftTotal = (float)ShaftCalculating(userShaftChoice);

        float total = GetCost(arrowTotal, flechingTotal, shaftTotal);
        Console.WriteLine($"Total : {total}");
    }

    public float GetCost(int arrow, int fleching, float shaft)
    {
        float total = (float)arrow + (float)fleching + shaft;
        return total;
    }

    public int userSwitchChoice(int userinput, int item1, int item2, int item3)
    {
        switch (userinput)
        {
            case 1:
                return item1;
                break;

            case 2:
                return item2;
                break;

            case 3:
                return item3;
                break;

            default:
                return userinput;
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

