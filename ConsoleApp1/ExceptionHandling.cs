using System;

public class ExceptionHandling
{
	public ExceptionHandling()
	{
        Console.WriteLine("\nExceptionHandling is initiated");

        try
        {
            Console.Write("\nEnter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            result = a / b;

            Console.WriteLine("\nDivision of " + a + " and " + b + " is " + result);
        }
        catch (DivideByZeroException e) // we can also give simply by 'Exception e' but also possible to give without any functional parameters also like catch { Console.WriteLine("error") }
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("\nProgram executed without crash");
        }

	}
}
