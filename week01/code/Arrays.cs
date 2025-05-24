using System.Linq.Expressions;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // First I will define a new array of multiples
        // then I will use a for to iterate from 1 until it get the length which I use as the limit 
        // after that will multiply the number by the number of iterations to finally added to the array

        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        double[] multiples = new double[length];
        int j = 0;
        for (double i = 1; i <= length; i++)
        {
            multiples[j] = number * i;
            j++;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start

        // I will define un for defining the number of iterations according to amount
        // then I will remove the last item to added to the fisrt position of the list

        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        for (int i = 1; i <= amount; i++)
        {
            int value = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            data.Insert(0, value);
        }
    }
}
