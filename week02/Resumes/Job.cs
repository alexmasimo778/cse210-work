public class Job
{
    public string JobTitle { get; set; } = ""; // Default to an empty string
    public string Company { get; set; } = ""; // Default to an empty string
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    // Constructor to initialize the job
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        JobTitle = jobTitle;
        Company = company;
        if (startYear > endYear)
        {
            throw new ArgumentException("StartYear cannot be greater than EndYear.");
        }
        StartYear = startYear;
        EndYear = endYear;
    }

    // Method to display job information
    public void DisplayJobInformation()
    {
        if (string.IsNullOrWhiteSpace(JobTitle) || string.IsNullOrWhiteSpace(Company))
        {
            Console.WriteLine("Job information is incomplete.");
        }
        else
        {
            Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
        }
    }
}