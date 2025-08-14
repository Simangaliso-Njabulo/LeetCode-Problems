using System;
using System.Collections.Generic;

public class Solution 
{
    /// <summary>
    /// Find two numbers in the array that add up to target.
    /// 
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </summary>
    /// <param name="nums">Array of integers</param>
    /// <param name="target">Target sum</param>
    /// <returns>Array of two indices whose values sum to target</returns>
    public int[] TwoSum(int[] nums, int target) 
    {
        // Dictionary to store number -> index mapping
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            // Calculate what number we need to find
            int complement = target - num;
            
            // Check if complement exists in our hash map
            if (numToIndex.ContainsKey(complement))
            {
                // Found the pair! Return indices
                return new int[] { numToIndex[complement], i };
            }
            
            // Store current number and its index for future lookups
            // Use indexer with check to handle potential duplicates gracefully
            numToIndex[num] = i;
        }
        
        // This line should never be reached given the problem constraints
        return new int[0];
    }
}