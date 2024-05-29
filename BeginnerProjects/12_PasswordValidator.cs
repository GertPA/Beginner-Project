
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



        if (testWord.Length >= 6 && testWord.Length <= 13)
        {
            Console.WriteLine($"The password has in total {testWord.Length} characters , within the acceptable range");
            if (CheckUpper(testWord) == true && CheckNumber(testWord) == true && CheckForRules(testWord) == true)
            {
                Console.WriteLine("This Password contains UpperCase latters and numbers");


            }
            else
            {
                Console.WriteLine("This Password doesnt contains UpperCase latters or numbers");
            }
        }
        else
        {
            Console.WriteLine($"The password has in total {testWord.Length} characters, pls input a password that has 6 to 13 letters ");

        }





        bool CheckNumber(string testWorld) //will Check If it contains a number
        {
            foreach (char item in testWorld)
            {
                for (int i = testWorld.Length - 1; i < testWorld.Length;)
                {
                    if (char.IsDigit(item) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return false;
        }
        bool CheckUpper(string testWorld) //will check if it contains a uppercase letter
        {
            foreach (char item in testWorld)
            {
                for (int i = testWorld.Length - 1; i < testWorld.Length;)
                {
                    if (char.IsUpper(item) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return false;
        }
        bool CheckForRules(string testWorld) // needs testing
        {
            for (int i = 0; i < testWorld.Length; i++)
            {
                if (testWorld[i] == 'T' && testWorld[i] == '&') return false;
                else return true;
            }
            return true;
        }


    }
}

