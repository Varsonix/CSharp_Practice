using System;
using System.Collections.Generic;
using System.Linq;

// Creating a method to run through an array and take the negative numbers and sum them while counting the number of positives.
// The return is an array with 2 indexes, the first being the count and the 2nd being the sum

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length < 1)
        {
        return Array.Empty<int>();
        }
        
        int[] result = new int[] {0, 0};
        
        for (int i=0; i<input.Length; i++)
        {
          if (input[i] < 0)
          {
            result[1] += input[i];
          }
          else if (input[i] > 0)
          {
            result[0]++;
          }
        }
        return result;
    }
    
}
