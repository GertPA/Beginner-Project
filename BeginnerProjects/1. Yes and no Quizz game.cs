
//Question to points
    class Quizz
    {

    private int score;
       
       public static void Main()
        {
            Quizz quizz = new Quizz();
            
            Console.WriteLine("Welcome to this quiz! Answer with \"yes\" or \"no\".");
            Console.ReadLine();

            Console.WriteLine("Lungs are the largest internal organ in the human body.");
            string? firstQuestion = Console.ReadLine();
            string firsQuestionStatus = "no";
            quizz.CheckingMethod(firstQuestion, firsQuestionStatus);

            Console.WriteLine(" The first song ever sung in the space was “Happy Birthday.”");
            string? secondQuestion = Console.ReadLine();
            string secondQuestionStatus = "yes";
            quizz.CheckingMethod(secondQuestion, secondQuestionStatus);

            Console.WriteLine("A male canary tends to have a better singing voice than a female canary.");
            string? thirdQuestion = Console.ReadLine();
            string thirdQuestionStatus = "yes";
           quizz.CheckingMethod(thirdQuestion, thirdQuestionStatus);

            Console.WriteLine("Dolphin is considered to be the fastest species in the ocean.");
            string? forthQuestion = Console.ReadLine();
            string forthQuestionStatus = "no";
            quizz.CheckingMethod(forthQuestion, thirdQuestionStatus);

            Console.WriteLine("Mice have more bones than humans.");
            string? fifthQuestion = Console.ReadLine();
            string fifthQuestionStatus = "yes";
            quizz.CheckingMethod(fifthQuestion, fifthQuestionStatus);

            var calculatingSCore = quizz.score >= 3 ? $"good job you scored {quizz.score}/3 whih is perfect" : $"well at least your tried your score is {quizz.score}";
            Console.WriteLine(calculatingSCore);

        }
        void CheckingMethod(string userInputedWord, string questionStatus) //will check if the answer is correct or nah 
        {
            if (userInputedWord.ToLower() == questionStatus)
            {
                Console.WriteLine("+1 good job");
                score++;
            }

            else if (userInputedWord.ToLower() != questionStatus)
            {
                Console.WriteLine("Wrong");
            }

            else
            {
                Console.WriteLine("invalid input , select yes or no ");
            }
        }
    }



