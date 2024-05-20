class Arrow
{
    //so this run the code ... yea 
  public static void Main()
{
   Arrow arrow1 = new Arrow();
}
    
    private bool reask = true;
    private int userShaftChoice;
    private enum Arrowheads : int { steel = 10, wood = 3, obsidian = 5 }
    private enum Fleching : int { plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3 }


    public Arrow()
    {
        Console.WriteLine("\tHellow and welcome to the shop \n\tpress enter to continue");
        Console.ReadLine();

        //pick the Material for the Arrow head
        Console.WriteLine("pick your arrow heads : \n1.Steel \n2.Wood \n3.Obsidian"); 
        int userArrowHeadChoice = Convert.ToInt16(Console.ReadLine());
        userSwitchChoice(userArrowHeadChoice, (int)Arrowheads.steel, (int)Arrowheads.wood, (int)Arrowheads.obsidian);

        while (reask)
        {
            //pick the shaft size
            Console.WriteLine("Please select your shaft size (minimum: 60, maximum: 100)."); 
            int userShaftChoice = Convert.ToInt16(Console.ReadLine());
            if (userShaftChoice >= 60 && userShaftChoice <= 100)//forces the user to chose between 60 and 100
            {

                Console.WriteLine($"Total price: {(float)ShaftCalculating(userShaftChoice)}");
                reask = false;
            }
            else
            {
                Console.WriteLine("Invalid input"); 

            }

        }
    
// user picking a fleching material
        Console.WriteLine("pick your fleching : \n1.Plastic \n2.Turkey Feathers \n3.Goose Feathers");
        int userFlechingChoice = Convert.ToInt16(Console.ReadLine());
        userSwitchChoice(userFlechingChoice, (int)Fleching.plastic, (int)Fleching.TurkeyFeathers, (int)Fleching.GooseFeathers);

//is this called "method overloading"? Anyways it makes it easy to get the cost for each part of the arrow 
        int arrowTotal = userSwitchChoice(userArrowHeadChoice, (int)Arrowheads.steel, (int)Arrowheads.wood, (int)Arrowheads.obsidian);
        int flechingTotal = userSwitchChoice(userFlechingChoice, (int)Fleching.plastic, (int)Fleching.TurkeyFeathers, (int)Fleching.GooseFeathers);
        float shaftTotal = (float)ShaftCalculating(userShaftChoice);

//Will calculate the final price
        float total = GetCost(arrowTotal, flechingTotal, shaftTotal); 
        Console.WriteLine($"Total : {total}");
    }

    //the method to get the final price
    public float GetCost(int arrow, int fleching, float shaft)
    {
        float total = (float)arrow + (float)fleching + shaft;
        return total;
    }
 
 //method to get 
    public int userSwitchChoice(int userinput, int item1, int item2, int item3) //
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


    public double ShaftCalculating(double userChoice) //Will calculate Shaft cost by size 
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
