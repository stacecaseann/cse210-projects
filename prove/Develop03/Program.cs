using System;
/*
To add extra to this program, I created a file called RandomScripture that holds about 15 scriptures and randomly selects them. 
I also added 2 ways to memorize the scripture - 1) By hiding the entire word with _ and 2) By showing the first letter only
Also it randomly selects a number between 1 and 5, and that's how many words it will hide each time.
*/
class Program
{
    static void Main(string[] args)
    {
        RandomScripture randomScripture = new();
        Scripture scripture = randomScripture.GetRandomScripture();
        string executeProgram = "Start";
        //1 = Hide entire word
        //2 = Display first letter
        int hideMethod = GetHideMethod();
        if (hideMethod == 3)
            executeProgram = "quit";
        bool newScripture = false;
        do
        {
            Console.Clear();
            if (executeProgram.Equals("Start"))
            {
                Console.WriteLine(scripture.GetDisplayText(hideMethod));
            }
            else if (newScripture)
            {
                hideMethod = GetHideMethod();
                if (hideMethod == 3)
                {
                    break;
                }   
                scripture = randomScripture.GetRandomScripture();
                Console.WriteLine(scripture.GetDisplayText(hideMethod));
                newScripture = false;
            }
            else
            {
                newScripture = scripture.HideRandomWords(GetRandomNumberToHide());
                Console.WriteLine(scripture.GetDisplayText(hideMethod));
                if (newScripture)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations, you have memorized this scripture!");
                }
            }
            executeProgram = Console.ReadLine();
        }
        while(!executeProgram.ToLower().Equals("quit"));

    }
    private static int GetRandomNumberToHide()
    {
        Random random = new Random();
        int randomNumber = random.Next(1,5);
        return randomNumber;
    }

    private static int GetHideMethod()
    {
        int method = -1;
        while (method != 1 || method != 2){
            Console.WriteLine("Would you like to memorize by hiding the entire word or by showing only the first letter?");
            Console.WriteLine("1: Hide entire word");
            Console.WriteLine("2: Show first letter");
            Console.WriteLine("3: Quit");
            string methodString = Console.ReadLine();
            if (int.TryParse(methodString, out method) && (method == 1 || method == 2 || method == 3))
            {
                return method;
            }
        }
        return method;
    }
}