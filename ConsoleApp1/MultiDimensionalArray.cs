using System;

public class MultiDimensionalArray
{
	public MultiDimensionalArray()
	{

        Console.WriteLine("\nMultiDimensionalArray is initiated");

        /* Declare multi dimensional array */

        int[,] TwoDimensionalArray1 = new int[2, 3]; // this means array with 2 row 3 column

        TwoDimensionalArray1[0, 0] = 1;
        TwoDimensionalArray1[0, 1] = 2;
        TwoDimensionalArray1[0, 2] = 3;
        TwoDimensionalArray1[1, 0] = 4;
        TwoDimensionalArray1[1, 1] = 5;
        TwoDimensionalArray1[1, 2] = 6;

        for(int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(TwoDimensionalArray1[i, j] + "\t");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\n----------------------------------\n");

        int[,] TwoDimensionalArray2 = new int[3, 3]
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        for (int i =0; i < 3; i++)
        {
            for (int j = 0; j<3; j++)
            {
                Console.Write(TwoDimensionalArray2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n----------------------------------\n");

        int[,] TwoDimensionalArray3 =
        {
            { 1, 2 },
            {3, 4 }
        };

        for (int i = 0; i< 2; i++)
        {
            for (int j = 0; j<2; j++)
            {
                Console.Write(TwoDimensionalArray3[i,j] + "\t");
            }
            Console.WriteLine();
        }


    }
}
