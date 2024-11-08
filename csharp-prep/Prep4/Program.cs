using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = [];
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
                numbers.Add(number);
        }
        int sum = 0;
        int largestNumber = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        double average = 0.0;
        if (numbers.Count != 0)
            average = (double)sum/numbers.Count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");
        numbers.Sort();
        Console.WriteLine("Sorted numbers");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}