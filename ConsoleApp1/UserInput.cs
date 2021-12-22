using System;

public class UserInput
{
	public UserInput()
	{
        Console.Write("Enter your name : ");
        string name = Console.ReadLine();

        Console.Write("Enter your age : ");
        string age = Console.ReadLine();

        Console.WriteLine("Hi " + name + " and you are " + age);

	}
}
