using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Enuit";
        job1._startYear = 2009;
        job1._endYear = 2024;

        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "QA";
        job2._company = "Nucleus";
        job2._startYear = 2000;
        job2._endYear = 2003;

        // job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Stacy Yarrington";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Console.WriteLine(resume._jobs[0]._jobTitle);
        resume.DisplayResume();
    }
}