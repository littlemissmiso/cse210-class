using System;

public class PictureBook : Book
{
    private string _illustrator = "";

    //------CONSTRUCTORS---------------- (Have to have a 2nd one for this class, the other one won't work)
    public PictureBook() : base()
    {

    }
    public PictureBook(string author, string title, string illustrator) : base(author, title)
    {
        _illustrator = illustrator;
    }

    public string GetIllustrator()
    {
        return _illustrator;
    }

    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetPictureBookInfo()
    {
        return $"{_title} by {_author} illustrated by {_illustrator}";
    }
}