using System;

public class WebDeveloper : Developer
{
    public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
    {
    }

    public void Develop() {
        Console.WriteLine("I develop myself by watching Udemy Web Development courses.");
    }
}