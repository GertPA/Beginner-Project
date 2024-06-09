//Instead of Prasing it now we can do it later

Console.WriteLine("How many hours have you played");
int playedHours = int.Parse(Console.ReadLine());
Console.WriteLine("How many minutes have you played?");
int playedMinutes = int.Parse(Console.ReadLine());
  
int totalH = 8;
int totalM = 30;
 

int calcH = playedHours + totalH;
int calcM = playedMinutes + totalM;
int differM = 0;
 

if (calcM >= 60)
{
    differM = calcM - 60;
    calcH += 1;
}

else
{
    differM = totalM +playedMinutes ;
}
   
Console.WriteLine($"Hours : {calcH} ");
Console.WriteLine($"Minutes: {differM}");
