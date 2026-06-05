using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // EXAMPLE: create a StringBuilder
            StringBuilder sb = new StringBuilder("Initial string.", 200);
            
            // EXAMPLE: print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // EXAMPLE: Add some strings to the builder using Append
            sb.Append("The quick brown fox ");
            sb.Append("jumped over the lazy dog.");


            // EXAMPLE: AppendLine can append a line ending
            sb.AppendLine();

            // EXAMPLE: AppendFormat can be used to append formatted strings
            sb.AppendFormat("He did this {0} times.", jumpCount);
            sb.AppendLine();

            // EXAMPLE: AppendJoin can iterate over a set of values
            sb.Append("He also jumped over ");
            sb.AppendJoin(',', animals);

            // EXAMPLE: Modify the content using Replace
            sb.Replace("fox", "cat");

            // EXAMPLE: Insert content at any index
            sb.Insert(0, "This is the ");
            
            // EXAMPLE: Convert to a single string
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            Console.WriteLine(sb.ToString()); // serialize all content in stringbuilding to final string
        }
    }
}
