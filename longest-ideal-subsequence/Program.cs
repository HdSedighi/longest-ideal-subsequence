class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello World!");
        var solution = new Solution();
        var result = solution.LongestSubsequence("acfgbd", 2);
        Console.WriteLine(result);
    }
}

class Solution {
        public int LongestSubsequence(string s, int k) {
        // Array to store the longest length of an ideal string ending with each character
        int[] dp = new int[26];
        int maxLength = 0;
        
        // Iterate through each character in the string s
        foreach (char c in s)
        {
            // Convert character to index (0 for 'a' to 25 for 'z')
            int charIndex = c - 'a';
            
            // Calculate the maximum length of an ideal string that ends with character c
            int maxLocalLength = 0;
            
            // Check all possible characters within the range of absolute difference k in the alphabet order
            for (int i = Math.Max(0, charIndex - k); i <= Math.Min(25, charIndex + k); i++)
            {
                maxLocalLength = Math.Max(maxLocalLength, dp[i]);
            }
            
            // Update dp[charIndex] with the maximum length found plus 1 for the current character
            dp[charIndex] = maxLocalLength + 1;
            
            // Update the global maximum length
            maxLength = Math.Max(maxLength, dp[charIndex]);
        }
        
        return maxLength;
    }

}