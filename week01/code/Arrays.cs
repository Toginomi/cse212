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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan for MultiplesOf
        // 1. Create an array of size 'length' to hold the multiples.
        // 2. Loop from 0 up to length - 1.
        // 3. For each index i, calculate number * (i+1).
        //    - (i+1) ensures we start with the first multiple (not zero).
        // 4. Store the result in the array at position i.
        // 5. Return the array after the loop finishes.

        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan for RotateListRight
        // 1. Identify the split point in the list: data.Count - amount.
        //    - This is where the list will be cut into two parts.
        // 2. Use GetRange to slice the last 'amount' elements (the part that rotates to the front).
        // 3. Use GetRange to slice the first data.Count - amount elements (the part that shifts to the back).
        // 4. Clear the original list.
        // 5. Add the rotated slices back in order: last part first, then the first part.

        int split = data.Count - amount;
        var lastPart = data.GetRange(split, amount);
        var firstPart = data.GetRange(0, split);

        data.Clear();

        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
