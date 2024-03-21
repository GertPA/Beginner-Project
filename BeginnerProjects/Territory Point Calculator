// •Create a program that allows users to enter how many provinces, duchies, and estates they have.
// • Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
// • Display the point total to the user.


int estatPoint = 1;
int dutchyPoint = 3;
int provincePoint = 6;

// string estate = "estate";
// string dutchy = "dutchy";
// string province = "province";

Console.WriteLine("How many estates do you have?");
int userEstate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
int userDutchy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many provinces do you have?");
int userProvincies = Convert.ToInt32(Console.ReadLine());

//The idea was to convey information about the point value of each territory,but i wasnt able to make it work 
// CalculatePlaces(estatPoint,userEstate,estate); 
// CalculatePlaces(dutchyPoint,userDutchy,dutchy);
// CalculatePlaces(provincePoint,userProvincies,dutchy);

int sum = CalculatePlaces(estatPoint,userEstate) + CalculatePlaces(dutchyPoint,userDutchy) + CalculatePlaces(provincePoint,userProvincies);
Console.WriteLine("The sum of points of each place is: " + sum + " points");

int CalculatePlaces(int placesPoints, int userPoints){
    int calculatingPoint = placesPoints * userPoints;
    return calculatingPoint;
        }
