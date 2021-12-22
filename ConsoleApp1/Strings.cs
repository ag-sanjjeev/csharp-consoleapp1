using System;

public class Strings
{
    public string content1;
    public string content2;

	public Strings(string content1, string content2)
	{
        Console.WriteLine("Strings initiated");

        this.content1 = content1;
        this.content2 = content2;

        Console.WriteLine("\nThe text inside content 1 is " + this.content1);
        Console.WriteLine("\nThe text inside content 2 is " + this.content2);

        string contents = $"{content1} {content2}";
        Console.WriteLine("\nString concatenation : " + contents);

        Console.WriteLine("\nThe length of text : " + this.content1.Length + "\t" + this.content2.Length);
        Console.WriteLine("\nUppercase : " + this.content1.ToUpper());
        Console.WriteLine("\nLowercase : " + this.content2.ToLower());

        Console.WriteLine("\nThe content has word hello :" + this.content1.Contains("hello"));
        Console.WriteLine("\nThe index of hello word is : " + this.content1.IndexOf("hello"));
        Console.WriteLine("\nSubstring : " + this.content1.Substring(6, 3));
        

	}
}
