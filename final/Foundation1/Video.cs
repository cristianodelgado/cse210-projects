using System;
using System.Collections.Generic;
public class Video
{
    public string  _title;
    public string  _autor;
    public int _lengthVideo;
    public List<Comment>Comments; 
    public Video (string title, string autor, int lengthVideo){
        _title = title;
        _autor = autor;
        _lengthVideo = lengthVideo;
        Comments = new List<Comment>();
    }
    public void AddComment(string name, string textComment){
        Comment comment = new Comment(name, textComment);
        Comments.Add(comment);
    }
    public int NumberComment()
    {
        return Comments.Count;

    }

}