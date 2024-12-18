using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [
            new Biking(new DateTime(2024,12,1), 47, 11),
            new Running(new DateTime(2024,12,2), 120, 13.1),
            new Swimming(new DateTime(2024,12,3), 60, 42)

        ];
        activities.ForEach(x => Console.WriteLine(x.GetSummary()));
    }
}