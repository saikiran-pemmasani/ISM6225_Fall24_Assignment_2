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
        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                List<int> total = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int val = Math.Abs(nums[i]) - 1;
                    if (nums[val] > 0)
                    {
                        nums[val] = -nums[val];
                    }
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        total.Add(i + 1);
                    }
                }
                return total;
            }
            catch (Exception)
            {
                throw;
            }
        }
 
        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                int[] total = new int[nums.Length];
                int Index_even = 0;
                int Index_odd = nums.Length - 1;
 
                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        total[Index_even++] = num;
                    }
                    else
                    {
                        total[Index_odd--] = num;
                    }
                }
                return total;
            }
            catch (Exception)
            {
                throw;
            }
        }
 
        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int needed = target - nums[i];
                    if (map.ContainsKey(needed))
                    {
                        return new int[] { map[needed], i };
                    }
                    map[nums[i]] = i;
                }
                return new int[0];
            }
            catch (Exception)
            {
                throw;
            }
        }
 
        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums);
                int elemetLength = nums.Length;
                return Math.Max(nums[elemetLength - 1] * nums[elemetLength - 2] * nums[elemetLength - 3], nums[0] * nums[1] * nums[elemetLength - 1]);
            }
            catch (Exception)
            {
                throw;
            }
        }
 
        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                if (decimalNumber == 0) return "0";
                string binary = "";
                while (decimalNumber > 0)
                {
                    binary = (decimalNumber % 2) + binary;
                    decimalNumber /= 2;
                }
                return binary;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DecimalToBinary: " + ex.Message);
                throw;
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
                    int middle = (left + right) / 2;
                    if (nums[middle] > nums[right])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle;
                    }
                }
                return nums[left];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in FindMin: " + ex.Message);
                throw;
            }
        }
 
        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0) return false;
                int org = x, rev = 0;
                while (x > 0)
                {
                    int digit = x % 10;
                    rev = rev * 10 + digit;
                    x /= 10;
                }
                return org == rev;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in IsPalindrome: " + ex.Message);
                throw;
            }
        }
 
        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                int x = 0, y = 1;
                for (int i = 2; i <= n; i++)
                {
                    int temp = x + y;
                    x = y;
                    y = temp;
                }
                return y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Fibonacci: " + ex.Message);
                throw;
            }
        }
    }
}