class Program //runs the class door , can be replaced with static void {etc i dont remember}
{
    public static void Main()
    {
        //why not instead of inputid password here, make it to ask the user to put a password
        Door door1 = new Door(322);

        
    }
}

class Door 
{
    enum doorState { Open, Closed, Locked } //the state of the door ... thats all
    private int passCode { get; } //it supposed to be set in the program class,hell if i can what that get does , learn it 
    private bool passwordStat = false;


    public Door(int _passCode)
    {
        passCode = _passCode; //dont know what it does 
        doorState currrent = doorState.Open; //the current status of the dor 

        switch (currrent) // bassed on the status of the door , you get "diffrent prompts"
        {
            case doorState.Open:
                {
                    Console.WriteLine("The door is open do you want to close it ?");
                    char userDoorChoice = Convert.ToChar(Console.ReadLine()!);
                    if (userDoorChoice == 'y')
                        goto case doorState.Closed; //i learned this this extra cool, it jumps to another case , how cool is that
                }
                break;

            case doorState.Closed:
                {
                    Console.WriteLine("The door is closed do you want to lock it ?");
                    char userDoorChoice = Convert.ToChar(Console.ReadLine()!);
                    if (userDoorChoice == 'y')
                    currrent = doorState.Locked;
                    goto case doorState.Locked;
                       }
                break; //add an else , so if you type "n" you will just exit the code, just make the break work

            case doorState.Locked:
                {
                    Console.WriteLine("the door is locked to unlock it pls provide a passcode"); 
                    passwordCheck(_passCode, passwordStat);
                    if (passwordStat == true)
                    {
                        Console.WriteLine("you can change your password to : ");
                        int changePassword = Convert.ToInt32(Console.ReadLine());
                        passCode = changePassword;
                    }
                    else
                    {
                        Console.WriteLine("The password was wrong so you little bitch cant change it ");
                    }
                }
                break;
            default:
            Console.WriteLine("how tf did you end up here ?");
                break;
        }
    }

    public bool passwordCheck(int stockpassword, bool passwordStatus) // why not make a loop untiul you find the correct pass
    {

        int userCode = Convert.ToInt32(Console.ReadLine());
        if (userCode == stockpassword)
        {
            Console.WriteLine("its open");
            return passwordStatus = true;
        }
        else
        {
            Console.WriteLine("Wrong");
            return passwordStatus = false;
        }
    }
}


