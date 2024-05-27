string  testWord  = "abcDef123";

if (testWord.Length >= 6 && testWord.Length <= 13 )
{
    Console.WriteLine($"The password has in total {testWord.Length} characters , within the acceptable range");
    if(numbersOrNot(testWord) == true && IsUpperOrNot(testWord)==true && IsLowerOrNot(testWord)==true )
    {
        // foreach(char item in testWord)
        // {
        //     for(int i =0;i<testWord.Length;i++)
        //     {
        //         Console.WriteLine(testWord[i]);
        //     }
        // }
    }
    else{
        Console.WriteLine("doesnt");

    }
 
}
else
{
    Console.WriteLine($"The password has in total {testWord.Length} characters, pls input a password that has 6 to 13 letters ");

}


bool numbersOrNot(string test) //see if it contains Numbers Or not
{
foreach (char word in test)
{
 if(char.IsDigit(word)==true) //make a method inside a method
 {
   return true;
 }
}
return false;
}

bool IsUpperOrNot(string test) //see if it contains UpperLetters Or not
{
foreach (char word in test)
{
 if(char.IsUpper(word)==true)
 {
   return true;
 }
}
return false;
}

bool IsLowerOrNot(string test) //see if it contains lower Or not
{
foreach (char word in test)
{
 if(char.IsLower(word)==true)
 {
   return true;
 }
}
return false;
}
