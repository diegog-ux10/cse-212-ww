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

        // Plan:
        // 1. Create a new array of doubles with size 'length'
        // 2. Loop through each position in the array (from 0 to length-1)
        // 3. For each position i, calculate the multiple as: number * (i+1)
        //    We use (i+1) because we want to start with 1x, 2x, 3x, etc.
        // 4. Return the completed array

        // Create a new array to hold the multiples
        double[] multiples = new double[length];

        // Fill the array with multiples of the number
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Return the array of multiples
        return multiples;
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

        // Plan:
        // 1. When we rotate a list to the right by 'amount', the last 'amount' elements 
        //    move to the beginning of the list, and the rest shift to the end
        // 2. Get a copy of the last 'amount' elements (these will move to the front)
        // 3. Get a copy of the remaining elements (these will move to the end)
        // 4. Clear the original list
        // 5. Add the elements from step 2 to the list (now at the front)
        // 6. Add the elements from step 3 to the list (now at the end)
        
        // Check if the list is empty or has only one element
        if (data.Count <= 1)
        {
            // No rotation needed
            return;
        }
        
        // Calculate the starting index for elements that will move to the front
        int startIndex = data.Count - amount;
        
        // Get the elements that will move to the front (last 'amount' elements)
        List<int> elementsToFront = data.GetRange(startIndex, amount);
        
        // Get the elements that will move to the end (remaining elements)
        List<int> elementsToEnd = data.GetRange(0, startIndex);
        
        // Clear the original list
        data.Clear();
        
        // Add the elements to the list in their new positions
        data.AddRange(elementsToFront);  // These go to the front
        data.AddRange(elementsToEnd);    // These go to the end
    }
}
