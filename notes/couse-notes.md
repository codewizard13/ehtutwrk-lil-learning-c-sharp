<!-- 🔗 Custom Stylesheet -->
<link rel="stylesheet" href="../_css/main.css">

# COURSE NOTES: Learning C#</span> (2023)


## 0. Introduction




### 0.0 An introduction to learning C#




### 0.1 What you should know

- Need basic foundational programming concepts
- Object-oriented programming concepts (classes, inheritance, etc.)
  - Programming Foundations: Object-Oriented Design
- IDE or Text Editor
  - VSCODE



### 0.2 Setting up your environment

- Need to have at least the .NET core development environment

> #TIP: **Find out what version of .NET is installed**:
> `dotnet --info`

> #TIP: **Get your .NET version number:**\
> `dotnet --version`

> #TIP: The full version of Visual Studio is NOT needed - you can use VSCODE or any other IDE or Text Editor


### 0.3 How to run the examples

- All examples are built as command line CLI console programs
- USE CMD in Windows, or Terminal in Mac

> #TIP: `Program.cs` is where our main code lives.

> #TIP: **How to run code:** `dotnet run`

> #GOTCHA: Because he's using .NET 7, you have to download and install that runtime -- the latest v. 10 runtime won't work/not backward compatible

#### SIDEBAR: How to remove the extra verbose output in the command line:

    ## ✅ The Command That Removes All Noise

    ```powershell
    dotnet run --no-build --no-restore
    ```

    This gives you **only** your program's actual output:
    ```
    Hello World!
    What is your name?
    ```

    No `Restore succeeded`, no build timestamps, no warning blocks — just your app.

    ## 🔄 Your New Workflow

    Since you're doing a tutorial and will keep editing code:

    | When You've...              | Run This Command                                             |
    | --------------------------- | ------------------------------------------------------------ |
    | Changed your code           | `dotnet build` *(then)* `dotnet run --no-build --no-restore` |
    | Just testing existing build | `dotnet run --no-build --no-restore`                         |

    **Example after editing:**
    ```powershell
    dotnet build
    dotnet run --no-build --no-restore
    ```

    ## ⚠️ Why This Works

    - `--no-restore` skips the NuGet package check
    - `--no-build` skips compilation and runs the existing `.dll`
    - Together they skip the CLI noise but still run your program

    ## 🎯 Bonus: Fix the Warning Long-Term

    The `NETSDK1138` warning appears because your project targets `net7.0` (out of support). Edit `HelloWorld.csproj`:

    ```xml
    <TargetFramework>net8.0</TargetFramework>
    ```

    Then your warnings disappear entirely and you can just use `dotnet run` normally again. But if your course requires `net7.0`, stick with the `--no-build --no-restore` workflow above.

    This is the cleanest setup for tutorial work without breaking the course requirements!



### 0.4 CoderPad Challenges

- Course includes automated code challenges that appear when you click on the `Challenge` links in the course's TOC
- Challenges hosted by CoderPad
- Recommend using a desktop browser for best experience
- Code challenge has 4 areas: instructions , code editor for your answer, test results, and output console

> #OBSERVATION: Seems similar to LeetCode and Boot.dev

> #TIP: The Console output in the lower left will give you automatic hints when you click `Test code` in the lower right

- When you finish each code challenge, return to the course TOC and then the next video will be his solution


## 1. Overview of C#




### 1.0 Hello World C#

> #GOTCHA: When I type the  `dotnet new console` in VSCODE in 2026, my `Program.cs` looks way different than his. Here's what I get:

`Console.WriteLine("Hello, World!");`

> #TIP: **Create new console app:** `dotnet new console`

> #TIP: To make mine look like his I can just type what he has on his screen like the follwing:

```cs
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```
- `using system`: means our program will be using code in the .NET System namespac
- **Namespaces**: help organize programs and prevent names in your code from colliding with names in .NET and other 3rd party libraries

- C# as a whole is Object-oriented natively and all the code is organized into classes
- The `Program` class is where we put our  `main` function (the entry point to the program)
- `void` means there's no return value
- The `Console` object represents a system terminal

> #TIP: In C# you have to have semicolon line-endings - not optional!

> #OBSERVATION: Using the namespace structure instead of the single line version (`Console.WriteLine...`) seems to automatically prevent the other verbose errors we were getting about .NET v7 deprecation before

- **Top-level statements**: The term for all the other namespace and class statements I just referenced

> #TIP: Starting with C# v.9 Microsoft allows you to drastically simplify by removing all the the top-level statements, so you have a more simple level like with JavaScript console type scripting simplicity.

### 1.1 Variables and data types

- **C# is a STRONGLY-TYPED language**: Strong typing -- where we explicitly specify the type of variable for each variable -- helps to cut down on programming errors.

```cs
// Declare some basic value type variables
int i = 10;
float f = 2.0f;
decimal d = 10.0m;
bool b = true;
char c = 'c';

// Declare a string - it's a collection of characters
string str = "a string";

// Declare an implicit variable
var x = 10;
var z = "Hello!";
```

> #TIP:  **null** means the variable has "no value"

```cs
// TODO: Declare an array of values
int[] vals = new int[5];
string[] strs = {"one","two", "three"};

// TODO: Print the values using a Formatting String
// Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i,c,b,str,f,d,x,z);

// TODO: "null" means "no value"
object obj = null;
// Console.WriteLine(obj);

// TODO: Implicit conversion between types
long bignum;
bignum = i;

// TODO: Explicit conversions
float i_to_f = (float)i;
Console.WriteLine("{0}",i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}", f_to_i);
```


### 1.2 Operators

- `exercises\01_Start\Overview\Operators\Program.cs`

```cs
// Declare some variables to excercise the operators
int x = 10, y = 5;
string a = "abcd", b = "efgh";

// TODO: Basic math operators are +, -, /, *
// Console.WriteLine("----- Basic Math -----");
Console.WriteLine((x / y) * x);
Console.WriteLine(a + b); // concatenates


// // TODO: Increment / decrement operators
// Console.WriteLine("----- Shorthand -----");
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);


// // TODO: Operators can be shorthand: a = a + b
// a += b;
Console.WriteLine(a);


// // TODO: Logical operators &&, ||
// Console.WriteLine("----- Logic Operators -----");
Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);


// null-coalescing operators
string str = null;
// TODO: the ?? operator uses left operand if not null, or right one if it is
Console.WriteLine(str ?? "Unknown string");


// TODO: the ??= operator assigns the right operand if the left one is null
// it replaces the code:
// if (variable is null) {
//    variable = somevalue;
// }
str ??= "New String";
Console.WriteLine(str);
```

### 1.3 Writing C# comments


#### Single Line Comments

```cs
// Single line comments start with two slashes
// You can have as many of these as you wants
Console.WriteLine("Hello World!");
```

#### Multi-Line Comments

```cs
/* Multiple line comments start with a slash and a star
and can continue for several lines 
until a closing star and slash are encountered */
```

#### XML style comments

```cs
/// XML Comments are used to help provide documentation
/// They start with triple-slashes and have a special syntax
/// <summary>
/// This is the main sample application function
/// </summary>
/// <param name='args'>An array of string arguments from the command line</param>
/// <returns>
/// No return value
/// </returns>
static void Main(string[] args)
{
...
```
> #TIP: **Learn what XML comment tags are available at**: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags

> #TIP: **To Automatically Generate the Documentation file:** Add directives in the project file (ending in `.csproj`). Example:

- Here are the directives to add to `Comments.csproj` below the `TargetFramework` property:
- **GenerateDocumentationFile:** Tells the compiler to generate documentation from the comments
- **DocumentationFile:** Specifies name of the documentation output file

```xml
<GenerateDocumentationFile>true</GenerateDocumentationFile>
<DocumentationFile>Comments.xml</DocumentationFile>
```

- The result will look like:

<div class="code-filename">Comments.csproj</div>

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>Comments.xml</DocumentationFile>
  </PropertyGroup>

</Project>
```

- Do `dotnet build` to build the finished executable without running
- The result will be the extracted comments from source code are now in a generated documentation file `Comments.xml`

<div class="code-filename">Comments.xml</div>

```xml
<?xml version="1.0"?>
<doc>
    <assembly>
        <name>Comments</name>
    </assembly>
    <members>
        <member name="M:Comments.Program.Main(System.String[])">
            XML Comments are used to help provide documentation
            They start with triple-slashes and have a special syntax
            <summary>
            This is the main sample application function
            </summary>
            <param name='args'>An array of string arguments from the command line</param>
            <returns>
            No return value
            </returns>
        </member>
    </members>
</doc>
```

### 1.4 Chapter Quiz


## 2. C# Program Flow

### 2.0 Conditionals with "if"

- Flow control / Conditionals
- Handling error conditions
- How to perform repetitive operations

- `Exercise Files > Start > Program Flow > Conditional-if > Program.cs`

#### Examples of Decisions Programs Make:

- Does a bank customer have enough money to make their withdrawl
- Did an airline customer enter the right reservation code to checkin for their flight

#### **Example IF Statement:**

```cs
int theVal = 51;

// TODO: if-else 
if (theVal == 50)
{
    Console.WriteLine("theVal is 50");
}
else if (theVal >= 51 && theVal <= 60)
{
    Console.WriteLine("theVal is between 51 and 60");
}
else
{
    Console.WriteLine("theVal is something else");
}
```            

> #TIP:  If you have a lot of else if conditionals, a `switch` statement is often a better option

- **ternary statement:** A condensed version of an if-else statement.

#### Example Ternary Statement:

```cs
Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");
```


### 2.1 Conditionals with "switch"

- Usually best when if-else statements would be too cumbersome to read

> #TIP: It is required to put a `break` statement at the end of each case section to prevent other case sections from executing

- Can also **group multiple case labels together**

> #TIP: The `default` label in a switch-statement is sort of like the catch-all `else` statement in an If-Else coditional; indicates what to do when none of the other case labels match the expression

> #TIP: As of C# v.7, you can use _any non-null expression (not just integers)_

- If statements are best when you are making a `boolean` decision. Switch statements are best when you have multiple decision points in a single section of code

> #TIP:  The maximum number of `if-else` conditionals to be practical is **4-5**

#### Example Switch Statement:

- Notice that cases 52-54 are in the same group

```cs
int theVal = 60;

// TODO: The switch statement
switch (theVal)
{
case 50:
    Console.WriteLine("theVal is 50");
    break;
case 51:
    Console.WriteLine("theVal is 51");
    break;
case 52:
case 53:
case 54:
    Console.WriteLine("theVal is between 52 and 54");
    break;
default:
    Console.WriteLine("theVal is something else");
    break;
}
```            


### 2.2 For loops

- For loops usually have a **control variable** (aka **_iteration count_**) that keeps track of the number of times it has run (traditionally declared as `i`)
- **loop condition:** if the condition is true the loop will keep going
- **increment statement:** where we increment the control variable
- **curly braces:** enclose the code we are going to execute

> #TIP:  Foreach-in loop can be used to iterate over sequences

> #TIP: Strings are also *sequences* (arrays in other languages)


#### Example For Loop:

```cs
int myVal = 15;
int[] nums = new int[] {3, 14, 15, 92, 6};
string str = "The quick brown fox jumps over the lazy dog";

// TODO: the basic for loop
Console.WriteLine("The basic for loop:");
for (int i = 0; i < myVal; i++)
{
    Console.WriteLine("i is currently {0}", i);
}
```

#### Example Foreach Loop:

```cs
// TODO: the foreach-in loop can be used to iterate over sequences
// Console.WriteLine("The foreach loop:");
foreach (int i in nums)
{
    Console.WriteLine("i is currently {0}", i);
}
```

#### Example Looping Through Characters in a String:

```cs
// TODO: count the number of o's in the string
var count = 0;
foreach (char c in str)
{
    if (c == 'o')
    {
        count++;
    }
}
Console.WriteLine("Counted {0} o characters", count);
```

> #TIP: **How to Print a Blank Line:** `Console.WriteLine();`



### 2.3 While loops


- For loops are usually used to execute code a given number of times; While loops execute until a certain condition is met. In other words, in a for loop, you know how many times it should execute, but in a while you don't
- In the **parentheses** you define the logical expression that will be evaluated each time though the loop

> #TIP: **How to Display Prompt and Receive Input from User:** `inputStr = Console.ReadLine();`

> #TIP: The `do-while` loop is always guaranteed to run at least one time, whereas the basic `while` loop may never execute


#### Example While Loop:

```cs
// TODO: basic while loop executes while the gate condition is true
Console.WriteLine("Basic while() loop:");
while (inputStr != "exit")
{
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered: {0}", inputStr);
}
```

#### Example Do-While Loop:

```cs
// TODO: the do-while loop always executes at least one time
Console.WriteLine("The  do-while() loop:");
do
{
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered: {0}", inputStr);
} while (inputStr != "exit");
```


### 2.4 Using break and continue

- Sometimes you want to be able to stop the execution of a loop before the ending condition is reached
- Ex: find first instance of a value that is larger than 40

> #OBSERVATION: This is basically the purpose of an indexOf function

> #TIP: Use the `break` statement to terminate the loop early

> #TIP: The `continue` statement causes the loop to skip over the rest of the statements in _this iteration_ and continue to the next iteration of the loop

#### Example Loop with Break:

```cs
int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

Console.WriteLine("Using break:");
foreach (int val in values)
{
    // print the value
    Console.WriteLine($"val is currently {val}");

    // TODO: The break statement stops the loop and exits
    if (val >= 40) { break; }
}
```

#### Example Loop with Continue:

```cs
int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

Console.WriteLine("Using continue :");
foreach (int val in values)
{
    // TODO: The continue statement skips the rest of the loop entirely
    // and jumps to the next iteration (if there is one)
    if (val >= 20 && val <= 29) { continue; }

    // print the value
    Console.WriteLine($"val is currently {val}");
}
```


### 2.5 Exceptions

- Sometimes things go wrong in our programs and its necessary to handle those errors so the user doesn't have a bad experience
- In C# we use a programming technique called **exception handling** to catch errors before the hit the user

- **try block:** the code that might cause an exeception that you want to catch if it does
- **catch block:** where the exception error can be handled before the user sees it; you can customize the error message for a better user experience

> #TIP: You can trigger a specific exception by using the `throw` statement

- **finally block:** Will always run even if none of the catch blocks are triggered; good place to do resource/garbage cleanup

> #TIP: Exceptions are used throughout C# and .NET; provide a good mechanism for ***grouping error-handling code which keeps the main program logic easier to read***

#### Example Generic Try-Catch Exception-Handler Block:

```cs
int x = 1002;
int y = 0;
int result;

// TODO: Generic try-catch expressions make error checking easier
try
{
    result = x / y;
    Console.WriteLine("The result is: {0}", result);
}
catch
{
    Console.WriteLine("Whoops!"); // in real life you'd handl much more gracefully
}
```            

#### Example Complex Real-World Try-Catch Exception-Handler Block:

```cs
int x = 1002;
int y = 0;
int result;

// TODO: Divide-by-zero Exception Handler
try
{
    if (x > 1000)
    {
        throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
    }
    result = x / y;
    Console.WriteLine("The result is: {0}", result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Whoops!");
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Sorry, 1000 is the limit");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("This code always runs");
}
```            
**Console Result:**

```bash
Sorry, 1000 is the limit
x has to be 1000 or less (Parameter 'x')
This code always runs
```

### 2.6 Chapter Quiz



## 3. C# Strings

### 3.0 String operations

- Examining how C# makes it easy to process string content

> #TIP: Get character length property to get length

- **ordinal comparison of two strings:** called directly on the String class (eg, `String.Compare()`)


#### Example String Operations:

```cs
// Declare some strings for the exercises
string outstr;
string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

// TODO: Length of a string 
Console.WriteLine(str1.Length);


// TODO: Access individual characters
Console.WriteLine(str1[14]);

// TODO: iterate over a string like any other sequence of values
foreach (char ch in str1)
{
    Console.Write(ch);
    if (ch == 'b')
    {
        Console.WriteLine();
        break;
    }
}

// TODO: String Concatenation         
outstr = String.Concat(strs);
Console.WriteLine(outstr);

// TODO: Joining strings together with Join
outstr = String.Join('.', strs);
Console.WriteLine(outstr);

outstr = String.Join("---", strs);
Console.WriteLine(outstr);

// TODO: String Comparison
// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
int result = String.Compare(str2, "This is a string");
Console.WriteLine(result);


// TODO: Equals just returns a regular Boolean
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);


// TODO: String Searching
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("fox"));

outstr = str1.Replace("fox", "cat");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf("fox"));
```            


#### Where to learn more about the String class:

- https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-10.0
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types


### 3.1 String formatting




### 3.2 String interpolation




### 3.3 Using StringBuilder




### 3.4 String parsing




### 3.5 </> Code Challenge: Count the data types




### 3.6 Solution: Count the data types




### 3.7 Chapter Quiz




## 4. C# Functions




### 4.0 Function basics




### 4.1 Named and default parameters




### 4.2 Reference and out parameters




### 4.3 Returning multiple values




### 4.4 </> Code Challenge: Palindrome




### 4.5 Solution: Palindrome




### 4.6 Chapter Quiz




## 5. Object-Oriented C#




### 5.0 Defining C# classes




### 5.1 Access modifiers




### 5.2 Defining properties




### 5.3 Inheritance




### 5.4 String representation




### 5.5 </> Code Challenge: Bank




### 5.6 Solution: Bank




### 5.7 Chapter Quiz




## 6. Conclusion




### 6.0 Next steps






