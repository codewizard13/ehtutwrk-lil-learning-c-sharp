
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("A man, a plan, a canal, Panama", 200);

        // TESTING
        HandleMaybePalindrome(sb.ToString());
        HandleMaybePalindrome("madam");
        HandleMaybePalindrome("Madam");
        HandleMaybePalindrome("Madame");
        HandleMaybePalindrome("Car lot");
        HandleMaybePalindrome("Able was I ere I saw Elba");
        HandleMaybePalindrome("A Toyota's a Toyota");
    }

    /* Function: determine if a string is a palindrome */
    public static bool IsPalindrome(string thestr)
    {
        //* STEP 1: Normalize the string (removing whitespace and punctuation) *
        StringBuilder sb = new StringBuilder();

        // Loop through and remove disallowed characters
        foreach (char c in thestr)
        {
            if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        string s = sb.ToString();
        int leftIndex = 0;
        int rightIndex = s.Length - 1;

        while (leftIndex < rightIndex)
        {
            if (s[leftIndex] != s[rightIndex])
            {
                return false;
            }

            leftIndex++;
            rightIndex--;
        }

        return true;
    }

    public static void HandleMaybePalindrome(String s)
    {
        if (IsPalindrome(s.ToString()))
        {
            Console.WriteLine($"Yep, the string {{{s}}} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"NOPE - {{{s}}} is NOT a palindrome!");
        }
    }


}


