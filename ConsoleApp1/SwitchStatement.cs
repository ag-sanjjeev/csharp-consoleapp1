using System;

public class SwitchStatement
{
	public SwitchStatement()
	{

        Console.WriteLine("Switch statement initiated");

        string dayname = getDayName(0);

        Console.WriteLine(dayname);

	}

    static string getDayName(int day)
    {
        string dayname = "";

        switch(day)
        {
            case 0:
                dayname = "Sunday";
                break;
            case 1:
                dayname = "Sunday";
                break;
            case 2:
                dayname = "Sunday";
                break;
            case 3:
                dayname = "Sunday";
                break;
            case 4:
                dayname = "Sunday";
                break;
            case 5:
                dayname = "Sunday";
                break;
            case 6:
                dayname = "Sunday";
                break;
            default:
                dayname = "Invalid day number";
                break;
        }

        return dayname;
    }
}
