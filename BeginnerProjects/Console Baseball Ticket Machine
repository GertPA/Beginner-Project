int adult = 20;
int children = 10;
int other=15;

Console.WriteLine("Welcome to the baseball Match Ticket Machine!");
Console.WriteLine("Baseball Match Detail:");

DateTime dateToday = DateTime.Now;
DateTime timeToday = DateTime.Now;
Console.WriteLine("Date:"+dateToday.ToString(" MMMM dd, yyyy"));
Console.WriteLine("Time:"+timeToday.ToString(" h:mm tt"));
TestingThis();

void TestingThis()
{
   int numberofSeats = 100;
Console.WriteLine("Total seats Available:"+numberofSeats);
Console.WriteLine("Ticket prices : \nAdult = 20$ \nChildren = 10$ \nOther = 15$");

Console.Write("Enter number of adult tickes :");
int adultTickets = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of adult tickes :");
int childrenTickets = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of adult tickes :");
int otherTickets = Convert.ToInt32(Console.ReadLine());


int totalPrice = CalculateTicketPrice(adultTickets,adult)+CalculateTicketPrice(childrenTickets,children)+CalculateTicketPrice(otherTickets,other);
Console.Write($"Total price :{totalPrice}$ \nTickets purchased successfully!" );

int CalculateTicketPrice(int ticketAmmount, int ticketPrice)
{
int totalPriceTag = ticketPrice * ticketAmmount;
return totalPriceTag;
}
}

//This will do for now its messy 
Console.WriteLine("Do you want to buy more tickets?(y/n):");
string userInput = Console.ReadLine();

if(userInput.ToLower()=="y"){
   TestingThisBitch();

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


   
