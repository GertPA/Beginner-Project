Console.WriteLine("Select Units you want to use :");
Console.WriteLine("1-Imperial Units (inches , pounds) \n2-Metric Units (cm , kg)");
int userInput = int.Parse(Console.ReadLine());


Console.WriteLine("What is your height?");
double userHeight = Double.Parse(Console.ReadLine());
Console.WriteLine("How much do you weight?");
double userWeight = Double.Parse(Console.ReadLine());

//Units to use 
switch (userInput)
{
    case 1:
        float bmiConvert = BmiCalculate(userHeight, userWeight) * 703;
        Classification(bmiConvert);
        break;

    case 2:
        double metersHeight = userHeight / 100;
        Classification(BmiCalculate(metersHeight, userWeight));
        break;

    default:
        Console.WriteLine("Invalid Input. Please type a number."); // Fixed the error message
        break;
}

//Calculate your BMI
float BmiCalculate(double height, double weight)
{
    double FinalUserHeight = Math.Pow(height, 2);
    double Bmi = weight / FinalUserHeight;
    return (float)Bmi;
}

//Classify based on your bmi
void Classification(float bmiClass)
{
    if (bmiClass < 18.5)
        Console.WriteLine($"Your BMI is:: {bmiClass} , meaning your UNDERWEIGHT");

    else if (bmiClass >= 18.5 && bmiClass <= 24.9)
        Console.WriteLine($"Your BMI is:: {bmiClass} , meaning your NORMAL");

    else if (bmiClass >= 25 && bmiClass <= 29.9)
        Console.WriteLine($"Your BMI is:: {bmiClass} , meaning your OVERWEIGHT");

    else 
        Console.WriteLine("Obese");
        }
