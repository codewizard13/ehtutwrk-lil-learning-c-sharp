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




### 1.4 Chapter Quiz




## 2. C# Program Flow




### 2.0 Conditionals with "if"




### 2.1 Conditionals with "switch"




### 2.2 For loops




### 2.3 While loops




### 2.4 Using break and continue




### 2.5 Exceptions




### 2.6 Chapter Quiz




## 3. C# Strings




### 3.0 String operations




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






