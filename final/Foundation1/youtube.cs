using System;

public class Youtube
{
    public string _title;
    public string _author;
    public int _length; 
    List<Comments> _comments = new List<Comments>();
   

    public Youtube(string title,string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }

    public int GetNumberComments()
    {
        return _comments.Count();
    }
}

