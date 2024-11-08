using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static double SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, double squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}