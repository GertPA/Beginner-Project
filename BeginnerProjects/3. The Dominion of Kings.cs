// •Create a program that allows users to enter how many provinces, duchies, and estates they have.
// • Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
// • Display the point total to the user.


using OmniSharp.Extensions.LanguageServer.Protocol.Models;

DomOfKings calculatingZone = new DomOfKings();
Console.WriteLine(calculatingZone);
class DomOfKings
{
    public enum Point {estates=1,dutchy=3,province=6}
    
public DomOfKings()
{

    Console.WriteLine("How many estates do you have?");
    int userEstate = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("How many duchies do you have?");
    int userDutchy = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("How many provinces do you have?");
    int userProvincies = Convert.ToInt32(Console.ReadLine());


    int sum = CalculatePlaces((int)Point.estates,userEstate) + CalculatePlaces((int)Point.dutchy, userDutchy) + CalculatePlaces((int)Point.province, userProvincies);
    Console.WriteLine("The sum of points of each place is: " + sum + " points");
}
int CalculatePlaces(int placesPoints, int userPoints)
{
    int calculatingPoint = placesPoints * userPoints;
    return calculatingPoint;
}

}
