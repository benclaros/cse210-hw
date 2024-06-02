using System;
using System.Collections.Generic;

namespace YouTubeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create 3-4 videos and add comments
            Video video1 = new Video("How to clutch in Valorant", "Keznit", 960);
            video1.AddComment(new Comment("Valo_pro", "That´s the amazing way to clutch"));
            video1.AddComment(new Comment("Asdasd", "Thanks for sharing!"));
            video1.AddComment(new Comment("JimmyG", "I learned a lot from this video."));
            videos.Add(video1);

            Video video2 = new Video("5 special tips about how to heal your teammate", "Mazino, SKT T1", 1280);
            video2.AddComment(new Comment("Cesar", "Another awesome video Maz"));
            video2.AddComment(new Comment("V U", "Good as always Maz"));
            video2.AddComment(new Comment("Flazz", "This kid is crazy"));
            videos.Add(video2);

            Video video3 = new Video("How to become a Pro Player in Valorant", "Horus, TLC", 540);
            video3.AddComment(new Comment("Aloprolopez", "appreciate the tips."));
            video3.AddComment(new Comment("FPerez", "Good tips."));
            video3.AddComment(new Comment("JPablo", "Excellent!"));
            videos.Add(video3);

            // Iterate through the list of videos and display information
            foreach (var video in videos)
            {
                Console.WriteLine();
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length (in seconds): " + video.Length);
                Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine("Comment by " + comment.Name + ": " + comment.Text);
                }

                Console.WriteLine();
            }
        }
    }
}