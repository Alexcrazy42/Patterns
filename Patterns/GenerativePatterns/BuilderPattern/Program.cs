/*
Pattern builder provides simple API for step-by-step contructing difficult object  
*/

Console.WriteLine("Привет");

class BlogPost
{
    public string title;
    public string text;
    public List<string> tags;
    public List<string> categories;

    // we can make a constructor, but it not very comfortable for many class properties
    // could to use pattern builder
}