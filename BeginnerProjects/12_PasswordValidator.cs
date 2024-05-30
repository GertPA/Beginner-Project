
class Program
{
    public static void Main()
    {
       
        Console.Write("Type your password : ");
        string userPassword = Console.ReadLine()!;
        PassWordValidator passVal = new PassWordValidator(userPassword);
           }
}

class PassWordValidator
{
    public string _testWord;


    public PassWordValidator(string testWord)
    {
        _testWord = testWord;
        


          //Dont Look at the statments plss
        if (testWord.Length >= 6 && testWord.Length <= 13)
        {
            Console.WriteLine($"The password has in total {testWord.Length} characters , within the acceptable range");

            if (CheckUpper(testWord) == true && CheckNumber(testWord) == true && CheckForRules(testWord) == false)
            {
                Console.WriteLine("This Password contains UpperCase latters and numbers,its within the acceptable range");
              
            }
            else if (CheckUpper(testWord) == false && CheckNumber(testWord) == true && CheckForRules(testWord) == true)
            {
                Console.WriteLine("This Password doesnt conntain a UpperCase latters. ");

            }
            else if (CheckUpper(testWord) == true && CheckNumber(testWord) == false && CheckForRules(testWord) == true)
            {
                Console.WriteLine("This Password doesnt contain numbers.");

            }
            else if (CheckUpper(testWord) == true && CheckNumber(testWord) == true && CheckForRules(testWord) == true)
            {
                Console.WriteLine("Your password shoulnt contain a capital T , nor should it have a '&' as a character");

            }
            else
            {
                Console.WriteLine("Waaat???");
            }
        }
        else
        {
            Console.WriteLine($"The password has in total {testWord.Length} characters, pls input a password that has 6 to 13 letters ");

        }


//THERE must BE another WAYY RIGHT
        bool CheckNumber(string testWorld) //will Check If it contains a number
        {
            foreach (char item in testWorld)
            {
                if (char.IsDigit(item) == true) return true;

            }
            return false;
        }

        bool CheckUpper(string testWorld) //will check if it contains a uppercase letter
        {
            foreach (char item in testWorld)
            {
                if (char.IsUpper(item) == true) return true;
            }
            return false;
        }

    }

    bool CheckForRules(string testWorld) // needs testing
    {
        foreach (char item in testWorld)
        {
            if (item == 'T' || item == '&') return true;
        }


        return false;
    }

}


