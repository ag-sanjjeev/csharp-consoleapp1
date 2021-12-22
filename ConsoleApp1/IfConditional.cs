using System;

public class IfConditional
{
    public IfConditional(string country, int age)
    {

        Console.WriteLine("\nIfConditional is initiated");

        if (country == "india" && age > 18)
        {
            Console.WriteLine("\nYou are indian and you are above 18 for eligible to vote");
        }
        else if (country != "india" && age > 18)
        {
            Console.WriteLine("\nYou are above 18 and you are not indian for eligible to vote");
        }
        else if (country == "india" && age <= 18)
        {
            Console.WriteLine("\nYou are indian but you are not above 18 for eligible to vote");
        }
        else
        {
            Console.WriteLine("\nYou are not indian and you are not above 18 for eligible to vote");
        }

    }
}
