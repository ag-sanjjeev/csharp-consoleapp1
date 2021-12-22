using System;

public class Loopings
{
	public Loopings()
	{
        Console.WriteLine("\nLoopings are initiated");

        Console.WriteLine("\nWhile Loop : \n");

        int index = 1;
        while (index <= 5)
        {
            Console.WriteLine(index);
            index++;
        }

        Console.WriteLine("\nDo..While Loop : \n");

        index = 1;

        do
        {
            Console.WriteLine(index);
            index++;
        } while (index <= 5);

        Console.WriteLine("\nFor Loop : \n");

        for (index = 1; index <=5; index++)
        {
            Console.WriteLine(index);
        }

	}
}
