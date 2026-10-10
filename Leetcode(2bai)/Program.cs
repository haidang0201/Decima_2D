using System;

Solution sol = new Solution();

// ===== Bài 1: Two Sum =====
Console.WriteLine("=== Two Sum ===");

int[] a1 = sol.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine("Example 1: [" + string.Join(", ", a1) + "]   (mong đợi: [0, 1])");

int[] a2 = sol.TwoSum(new int[] { 3, 2, 4 }, 6);
Console.WriteLine("Example 2: [" + string.Join(", ", a2) + "]   (mong đợi: [1, 2])");

int[] a3 = sol.TwoSum(new int[] { 3, 3 }, 6);
Console.WriteLine("Example 3: [" + string.Join(", ", a3) + "]   (mong đợi: [0, 1])");

// ===== Bài 2: Missing Number =====
Console.WriteLine();
Console.WriteLine("=== Missing Number ===");

Console.WriteLine("Example 1: " + sol.MissingNumber(new int[] { 3, 0, 1 }) + "   (mong đợi: 2)");
Console.WriteLine("Example 2: " + sol.MissingNumber(new int[] { 0, 1 }) + "   (mong đợi: 2)");
Console.WriteLine("Example 3: " + sol.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }) + "   (mong đợi: 8)");