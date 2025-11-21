using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef Mario", 300);
        video1.AddComment(new Comment("Anna", "Great recipe!"));
        video1.AddComment(new Comment("Luis", "Tried it today, delicious!"));
        video1.AddComment(new Comment("Maria", "Can you make a vegan version?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Learn C# in 10 Minutes", "TechGuru", 600);
        video2.AddComment(new Comment("John", "Very helpful tutorial."));
        video2.AddComment(new Comment("Sara", "Thanks for explaining clearly."));
        video2.AddComment(new Comment("Peter", "I finally understand classes!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Traveling in Japan", "AdventureTime", 900);
        video3.AddComment(new Comment("Alex", "Japan looks amazing!"));
        video3.AddComment(new Comment("Kevin", "I want to visit Mount Fuji."));
        video3.AddComment(new Comment("Lily", "The food shots were incredible."));
        videos.Add(video3);

        // Display all video info
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}
