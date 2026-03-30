using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create some videos
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        video1.Title = "Learning C# Basics";
        video1.Author = "CodeMaster";
        video1.LengthSeconds = 600;

        video1.AddComment(new Comment("Alex", "Great tutorial!"));
        video1.AddComment(new Comment("Sam", "Very helpful."));
        video1.AddComment(new Comment("Jordan", "Please make part 2!"));

        videos.Add(video1);

        Video video2 = new Video();
        video2.Title = "Object-Oriented Programming";
        video2.Author = "TechGuru";
        video2.LengthSeconds = 850;

        video2.AddComment(new Comment("Chris", "Now I understand classes!"));
        video2.AddComment(new Comment("Taylor", "Awesome explanation."));
        video2.AddComment(new Comment("Morgan", "Saved my exam!"));

        videos.Add(video2);

                Video video3 = new Video();
        video3.Title = "Top 10 VS Code Extensions";
        video3.Author = "DevLife";
        video3.LengthSeconds = 420;

        video3.AddComment(new Comment("Pat", "Installing them now."));
        video3.AddComment(new Comment("Lee", "Super useful."));
        video3.AddComment(new Comment("Casey", "Thanks for sharing!"));

        videos.Add(video3);

         foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}