using System;

BaseballTicketMachine test = new BaseballTicketMachine();
Console.Write(test);
class BaseballTicketMachine
{
    public (int adult, int children, int other) ticketPriceList = (20, 10, 15);


    public BaseballTicketMachine()
    {
        Console.WriteLine("Welcome to the baseball Match Ticket Machine!");
        Console.WriteLine("Baseball Match Detail:");

        DateTime dateToday = DateTime.Now;
        DateTime timeToday = DateTime.Now;
        Console.WriteLine("Date:" + dateToday.ToString(" MMMM dd, yyyy"));
        Console.WriteLine("Time:" + timeToday.ToString(" h:mm tt"));
        TestingThis();
        Console.WriteLine("\tDo you want to buy more tickets?(y/n):");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "y")
        {
             TestingThis();

            Console.WriteLine("Process exited after 10 seconds \n Press any key to continue");
            Thread.Sleep(1000);
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Process exited after 10 seconds \n Press any key to continue");
            Thread.Sleep(1000);
            Console.ReadLine();
        }
    }

    public void TestingThis()
    {
        int numberofSeats = 100;
        Console.WriteLine("Total seats Available:" + numberofSeats);
        Console.WriteLine("Ticket prices : \nAdult = 20$ \nChildren = 10$ \nOther = 15$");

        Console.Write("Enter number of Adult tickes :");
        int adultTickets = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of Children tickes :");
        int childrenTickets = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of Other Types of tickes :");
        int otherTickets = Convert.ToInt32(Console.ReadLine());


        int totalPrice = CalculateTicketPrice(adultTickets, ticketPriceList.adult) + CalculateTicketPrice(childrenTickets, ticketPriceList.children) + CalculateTicketPrice(otherTickets, ticketPriceList.other);
        Console.Write($"Total price :{totalPrice}$ \nTickets purchased successfully!");

        int CalculateTicketPrice(int ticketAmmount, int ticketPrice)
        {
            int totalPriceTag = ticketPrice * ticketAmmount;
            return totalPriceTag;
        }
    }

}

   
