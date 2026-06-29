
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Initial String", 200);

        HandleMaybePalindrome(sb.ToString());

    }

    /* Function: determine if a string is a palindrome */
    public static bool IsPalindrome(String thestr)
    {
        //* STEP 1: Normalize the string (removing whitespace and punctuation) *
        // // Rebuild cleaned string using StringBuilder 
        StringBuilder sb = new StringBuilder(thestr);

        // Loop through and remove disallowed characters
        foreach (Char c in thestr)
        {
            if (!Char.IsPunctuation(c) && !Char.IsWhiteSpace(c))
            {
                sb.Append(Char.ToLower(c));
            }
        }

        // Verify cleaned string 
        Console.WriteLine($"Cleaned string: \n");
        Console.WriteLine(sb.ToString());
        
        //* STEP 2: Test cleaned string for palindromicity *
        string s = sb.ToString(); int leftIndex = 0; int rightIndex = s.Length - 1; while (leftIndex < rightIndex)
        {
            // Check if check if c = s[right] 
            if (s[leftIndex] != s[rightIndex])
            {
                // Early return 
                return false;
            }
            else
            {
                // Increment left, decrement right 
                leftIndex++; rightIndex--;
            }
        }
        return true;
    }

    public static void HandleMaybePalindrome(String s)
    {
        if (IsPalindrome(s.ToString()))
        {
            Console.WriteLine("Yep, the string is a palindrome.");
        }
        else
        {
            Console.WriteLine("NOPE - It's NOT a palindrome!");
        }
    }


}


