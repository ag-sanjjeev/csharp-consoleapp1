using System;

public class DataTypes
{
    public string name;
    public char gender;
    public int age;

    /* Float Double Decimal are same usage for decimal numbers */

    public float a, b;
    public double c, d;
    public decimal e, f; /* but more precise about decimal places like money, scientific calculation then decimal data type useful */

    public bool isMarried;

	public DataTypes(string name, char gender, int age, float a, float b, double c, double d, decimal e, decimal f, bool isMarried)
	{
        Console.WriteLine("Data types initiated");

        this.name = name;
        this.gender = gender;
        this.age = age;
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.e = e;
        this.f = f;


        Console.WriteLine("\nName is " + this.name + " \t with character length of " + this.name.Length);
        Console.WriteLine("\nGender is " + this.gender);
        Console.WriteLine("\nAge is " + this.age);
        Console.WriteLine("\nAddition of float data type numbers " + (this.a + this.b) );
        Console.WriteLine("\nSubtraction of double data type numbers " + (this.c + this.d));
        Console.WriteLine("\nMultiplication of decimal data type numbers " + (this.e * this.f) );
        Console.WriteLine("\nMaritial Status " + this.isMarried);

	}
    
}
