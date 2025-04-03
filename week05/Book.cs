using System;

public class Book
{
    protected string _author = "";
    protected string _title = "";

//---------CONSTRUCTORS---------------
    public Book()
    {
        _author = "Anonymous";
        _title = "Unknown";
    }

    public Book(string author, string title)
    {
        _author = author;
        _title = title;
    }

//----------GETTERS & SETTERS----------------
    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTItle();
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }


//---------END GETTERS & SETTERS--------------

    public string GetBookInfo()
    {
        return $"{_title} by {_author}";
    }

}

