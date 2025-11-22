using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef Mario", 657);
        video1.AddComment(new Comment("Anna", "Great recipe!"));
        video1.AddComment(new Comment("Luis", "Tried it today, delicious!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Learn HTML in 10 Minutes", "TechWizard2020", 667);
        video2.AddComment(new Comment("John", "Very helpful tutorial."));
        video2.AddComment(new Comment("Sara", "Thanks for explaining clearly."));
        video2.AddComment(new Comment("Peter", "I finally understand classes!"));
        video2.AddComment(new Comment("Harold", "Can you make a video on CSS next?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Traveling in Peru, Cusco", "GaryTraveler", 900);
        video3.AddComment(new Comment("Alex", "Peru looks amazing!"));
        video3.AddComment(new Comment("Kelvin", "I want to visit Machu Picchu."));
        video3.AddComment(new Comment("Lily", "The food shots were incredible!"));
        videos.Add(video3);

        // Display all video info
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}
