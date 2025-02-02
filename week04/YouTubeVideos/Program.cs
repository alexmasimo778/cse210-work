
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video { Title = "C# Basics", Author = "John Doe", Length = 600 };
        Video video2 = new Video { Title = "OOP in C#", Author = "Jane Smith", Length = 900 };
        Video video3 = new Video { Title = "Advanced C#", Author = "Alex Johnson", Length = 1200 };

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        // Add comments to video2
        video2.AddComment(new Comment("Daniel", "OOP is fun!"));
        video2.AddComment(new Comment("Eve", "Clear explanation!"));
        video2.AddComment(new Comment("Frank", "I finally understand classes."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Advanced concepts are well explained."));
        video3.AddComment(new Comment("Hank", "Challenging but interesting."));
        video3.AddComment(new Comment("Ivy", "I will watch this again."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}









