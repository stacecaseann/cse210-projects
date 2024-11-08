using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");
        int grade = int.Parse(Console.ReadLine());

        string gradeString = "A";
        if (grade >= 90)
        {
            gradeString = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            gradeString = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            gradeString = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            gradeString = "D";
        }
        else if (grade < 60)
        {
            gradeString = "F";
        }
        string plusMinus = "";
        int remainder = grade % 10;
        if (remainder >= 7 && grade < 90 && grade > 60)
            plusMinus = "+";
        else if (remainder < 3 && grade > 70)
            plusMinus = "-";
        Console.WriteLine($"Your grade is {gradeString}{plusMinus}.");
        if (grade >=70 )
        {
            Console.WriteLine("Congratulations you passed the class!");            
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}