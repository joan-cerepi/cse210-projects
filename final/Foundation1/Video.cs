using System;
using System.Collections.Generic;

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine();

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            string name = comment.GetName();
            string text = comment.GetText();
            Console.WriteLine($"\"{text}\" - {name}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}