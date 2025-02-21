using ExerciseTracking;  

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

            // Create instances for each activity
            List<Activity> activities = new List<Activity>
            {
                new Running("03 Nov 2022", 30, 4.8),
                new Cycling("03 Nov 2022", 45, 22.0),
                new Swimming("03 Nov 2022", 30, 40)
            };

            // Display summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}










