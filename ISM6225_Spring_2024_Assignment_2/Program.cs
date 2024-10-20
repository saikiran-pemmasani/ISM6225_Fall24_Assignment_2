using System;
using System.Collections.Generic;
 
namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));
 
            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));
 
            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));
 
            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);
 
            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);
 
            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);
 
            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);
 
            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
    }
        // Question 1: Find Missing Number in Array
public static IList<int> FindMissingNumbers(int[] nums)
{
    try
    {
        List<int> total = new List<int>(); // Initialize a list to store missing numbers
        for (int i = 0; i < nums.Length; i++)
        {
            int val = Math.Abs(nums[i]) - 1; // Calculate the index to mark
            if (nums[val] > 0)
            {
                nums[val] = -nums[val]; // Mark the number as seen by making it negative
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                total.Add(i + 1); // If a number is positive, it means i+1 is missing
            }
        }
        return total; // Return the list of missing numbers
    }
    catch (Exception)
    {
        throw; // Re-throw any caught exception
    }
}

// Question 2: Sort Array by Parity
public static int[] SortArrayByParity(int[] nums)
{
    try
    {
        int[] total = new int[nums.Length]; // Create a new array to store the sorted result
        int Index_even = 0; // Index for even numbers (start of the array)
        int Index_odd = nums.Length - 1; // Index for odd numbers (end of the array)

        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                total[Index_even++] = num; // Place even numbers at the beginning
            }
            else
            {
                total[Index_odd--] = num; // Place odd numbers at the end
            }
        }
        return total; // Return the sorted array
    }
    catch (Exception)
    {
        throw; // Re-throw any caught exception
    }
}

// Question 3: Two Sum
public static int[] TwoSum(int[] nums, int target)
{
    try
    {
        Dictionary<int, int> map = new Dictionary<int, int>(); // Create a dictionary to store number-index pairs
        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i]; // Calculate the complement needed
            if (map.ContainsKey(needed))
            {
                return new int[] { map[needed], i }; // If complement found, return the indices
            }
            map[nums[i]] = i; // Add current number and its index to the dictionary
        }
        return new int[0]; // Return empty array if no solution found
    }
    catch (Exception)
    {
        throw; // Re-throw any caught exception
    }
}

// Question 4: Find Maximum Product of Three Numbers
public static int MaximumProduct(int[] nums)
{
    try
    {
        Array.Sort(nums); // Sort the array in ascending order
        int elemetLength = nums.Length;
        // Return the maximum of (product of three largest numbers) and (product of two smallest and the largest number)
        return Math.Max(nums[elemetLength - 1] * nums[elemetLength - 2] * nums[elemetLength - 3], nums[0] * nums[1] * nums[elemetLength - 1]);
    }
    catch (Exception)
    {
        throw; // Re-throw any caught exception
    }
}

// Question 5: Decimal to Binary Conversion
public static string DecimalToBinary(int decimalNumber)
{
    try
    {
        if (decimalNumber == 0) return "0"; // Special case for 0
        string binary = "";
        while (decimalNumber > 0)
        {
            binary = (decimalNumber % 2) + binary; // Prepend the remainder to the binary string
            decimalNumber /= 2; // Divide the number by 2
        }
        return binary; // Return the binary representation
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error in DecimalToBinary: " + ex.Message);
        throw; // Re-throw the exception after logging
    }
}

// Question 6: Find Minimum in Rotated Sorted Array
public static int FindMin(int[] nums)
{
    try
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int middle = (left + right) / 2; // Calculate the middle index
            if (nums[middle] > nums[right])
            {
                left = middle + 1; // Minimum is in the right half
            }
            else
            {
                right = middle; // Minimum is in the left half or at middle
            }
        }
        return nums[left]; // Return the minimum element
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error in FindMin: " + ex.Message);
        throw; // Re-throw the exception after logging
    }
}

// Question 7: Palindrome Number
public static bool IsPalindrome(int x)
{
    try
    {
        if (x < 0) return false; // Negative numbers are not palindromes
        int org = x, rev = 0;
        while (x > 0)
        {
            int digit = x % 10; // Get the last digit
            rev = rev * 10 + digit; // Build the reversed number
            x /= 10; // Remove the last digit from x
        }
        return org == rev; // Check if the original number equals its reverse
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error in IsPalindrome: " + ex.Message);
        throw; // Re-throw the exception after logging
    }
}

// Question 8: Fibonacci Number
public static int Fibonacci(int n)
{
    try
    {
        if (n == 0) return 0; // Base case for n = 0
        if (n == 1) return 1; // Base case for n = 1
        int x = 0, y = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = x + y; // Calculate next Fibonacci number
            x = y; // Update x to previous y
            y = temp; // Update y to new Fibonacci number
        }
        return y; // Return the nth Fibonacci number
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error in Fibonacci: " + ex.Message);
        throw; // Re-throw the exception after logging
    }
}