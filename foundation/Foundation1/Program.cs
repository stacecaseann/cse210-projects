using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "How to Ride a Bike",
            "Bobby Brown",
            58
            );
        Video video2 = new Video(
            "Babies Laughing",
            "Allison Jones",
            47
        );
        List<Video> videos = [
            video1, video2
        ];
        foreach(var video in videos)
        {
            Console.WriteLine(video.DisplayDetails());
        }
    }
}