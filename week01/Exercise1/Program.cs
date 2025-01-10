using System;

using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
    
        Console.Write("Write your first name " );
        string first =Console.ReadLine();
        Console.Write("write your last name ");
        string last=Console.ReadLine();
        Console.WriteLine($"I am {last} ,{first}.");
    }    
}