using System;
using System.Threading;

public class Timer
{
    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rTime remaining: {i} seconds  ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\nTime's up!");
    }
}
