// C# code​​​​​​‌‌‌‌‌​‌‌‌‌​‌‌​​‌​​​‌​‌​‌​ below
using System;

public class Answer {
    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public  static Boolean ShowExpectedResult = true;
    public  static Boolean ShowHints = true;

    public static bool CountTheType(object Arg, string TypeToCount) {
        // Your code goes here. Return true if the type of the Arg is the same
        // as what the TypeToCount parameter says to count.
        if (Arg.GetType().ToString().Equals(TypeToCount)) {
            return true;
        }
        return false;
    }
}
