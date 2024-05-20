// •Create a program that allows users to enter how many provinces, duchies, and estates they have.
// • Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
// • Display the point total to the user.


class DomOfKings
{
    public int estates;
    public int dutchy;
    public int province;

public int CalculatePlaces(int placesPoints, int userPoints)
{
    int calculatingPoint = placesPoints * userPoints;
    return calculatingPoint;
}

}

class Program
{
    static void Main()
    {
DomOfKings dok = new DomOfKings();
    dok.estates=1;
    dok.dutchy=3;
    dok.province=6;

    Console.WriteLine("How many estates do you have?");
    int userEstate = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("How many duchies do you have?");
    int userDutchy = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("How many provinces do you have?");
    int userProvincies = Convert.ToInt32(Console.ReadLine());


    int sum = dok.CalculatePlaces(dok.estates,userEstate) + dok.CalculatePlaces(dok.dutchy, userDutchy) + dok.CalculatePlaces(dok.province, userProvincies);
    Console.WriteLine("The sum of points of each place is: " + sum + " points");
    }
}
