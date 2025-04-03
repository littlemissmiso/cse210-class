using System;

class Library
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("LittleMissMiso");
        book2.SetTitle("Catnip Stories");
        book2.SetIllustrator("L.M. Miso");

        Console.WriteLine(book2.GetBookInfo());

        Book book3 = new Book("Sassafrass", "Another Book");
        Console.Writeline(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Montgomery", "Tales of Trout", "Moses P. Teabody");
        Console.WriteLine(book4.GetBookInfo());
    }
}