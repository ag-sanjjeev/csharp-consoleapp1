using System;

public class Arrays
{
	public Arrays()
	{

        Console.WriteLine("Arrays inititated");

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] names = new string[2]; // initialise array with limit of two

        names[0] = "sanjjeev";
        names[1] = "gaanth";

        Console.WriteLine("\nFirst index number is : " + numbers[0]);
        Console.WriteLine("\nLast index name is : " + names[1]);

	}
}
