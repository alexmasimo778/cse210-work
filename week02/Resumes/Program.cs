using System;

using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
<
    }
}


        // Create the first job
        Job Job1 = new Job
        {
            JobTitle = "Software Engineer",
            Company = "BYU-Idaho",
            StartYear = 2020,
            EndYear = 2023
        };

        // Create the second job
        Job job2 = new Job
        {
            JobTitle = "Web Developer",
            Company = "Tech Solutions",
            StartYear = 2017,
            EndYear = 2020
        };

        // Create the resume
        Resume myResume = new Resume
        {
            PersonName = "John Doe",
            Jobs = new List<Job> { job1, job2 }
        };

        // Display the resume
        myResume.DisplayResume();
    }
}

class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void DisplayJobInformation()
    {
        Console.WriteLine($"Job Title: {JobTitle}");
        Console.WriteLine($"Company: {Company}");
        Console.WriteLine($"Start Year: {StartYear}");
        Console.WriteLine($"End Year: {EndYear}");
        Console.WriteLine();
    }
}

class Resume
{
    public string PersonName { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {PersonName}");
        Console.WriteLine("Jobs:");
        foreach (var job in Jobs)
        {
            job.DisplayJobInformation();
        }
    }
}

















