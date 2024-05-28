
string testWord = "Ablc123";


  

if (testWord.Length >= 6 && testWord.Length <= 13)
{
    Console.WriteLine($"The password has in total {testWord.Length} characters , within the acceptable range");
}
else
{
    Console.WriteLine($"The password has in total {testWord.Length} characters, pls input a password that has 6 to 13 letters ");

}
if (CheckUpper(testWord) ==true && CheckNumber(testWord)==true && CheckForRules(testWord)==true )
{
    Console.WriteLine("This Password contains UpperCase latters and numbers");
  

}
else 
{
    Console.WriteLine("This Password doesnt contains UpperCase latters or numbers");
}


bool CheckNumber(string testWorld)
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
bool CheckUpper(string testWorld)
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
bool CheckForRules(string testWorld)
{
        for (int i = 0; i < testWorld.Length; i++)
    {
        if(testWorld[i] =='T' && testWorld[i] =='&' ) return false;
        else return true;
    }
return true;
}

