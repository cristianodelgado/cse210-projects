using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video(title: "Video 1", autor:"Author 1", lengthVideo: 200);
        video1.AddComment(name: "User 1", textComment: "Comment 1"); 
        video1.AddComment(name: "User 2", textComment: "Comment 2");
        video1.AddComment(name: "User 3", textComment: "Comment 3"); 
        video1.AddComment(name: "User 4", textComment: "Comment 4");
        _videos.Add(video1);

        Video video2 = new Video(title: "Video 2", autor:"Author 2", lengthVideo: 170);
        video2.AddComment(name: "User 1.2", textComment: "Comment 1.2"); 
        video2.AddComment(name: "User 2.2", textComment: "Comment 2.2");
        video2.AddComment(name: "User 3.2", textComment: "Comment 3.2"); 
        video2.AddComment(name: "User 4.2", textComment: "Comment 4.2");
        _videos.Add(video2);

        Video video3 = new Video(title: "Video 3", autor:"Author 3", lengthVideo: 130);
        video3.AddComment(name: "User 1.3", textComment: "Comment 1.3"); 
        video3.AddComment(name: "User 2.3", textComment: "Comment 2.3");
        video3.AddComment(name: "User 3.3", textComment: "Comment 3.3"); 
        video3.AddComment(name: "User 4.3", textComment: "Comment 4.3");
        _videos.Add(video3);  

        foreach(Video v in _videos)
        {
            Console.WriteLine($"Title:  {v._title}.");
            Console.WriteLine( $"Author:  {v._autor}.");
            Console.WriteLine( $"Length: {v._lengthVideo} seconds.");
            Console.WriteLine( $"Number of Comments: {v.NumberComment()}.");
            Console.WriteLine( $"Comments: ");
            foreach (Comment comment in v.Comments)
            {
                Console.WriteLine($"Comment by: {comment._name}");
                Console.WriteLine($"Comment text: {comment._textComment}");
            }
        }      
        Console.WriteLine();
    }
}