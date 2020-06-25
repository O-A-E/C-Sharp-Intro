using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two slashes mark the beginning of a single comment line.
           // We are assigning a string value to a variable.
           string myName = "Osase";
           /* We begin multi line comments with a forward asterisk

            Symbols between values or evaluations are considered "operators." Below we are using the addition
            symbol to concatenate two strings. (concantenation means gluing two strings, or texts, together.)

           ... and end multi line comments with an asterisk followed by a forward slash */
            Console.WriteLine("Hello, " + myName);

            Console.writeline("Please enter your name...";)

            // Assign variable 'username' to a value entered by the use.

            string username = Console.Readline();
            // Show user we collected their name.
            console.writeline("You have entered: " +username);
            //Instead of traditional concatenation using the addition operator
            // We can use string interpolatio (place holders) to embed values in
            // a string!
            // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated

           
            console.writeline("Hey {0}, you're looking great today!" , username);
            // Let's play with strings!
            console.writeline( "makemeuppercase".ToUpper() ); //Convert to uppercase
            console.writeline("MAKEMELOWERCASE". ToLower() ); //Convert to lowercase
            // Substring takes two arguments: 1) Starting character position 2) Number of characters to collect.
            console.writeline( "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 4, 6  ) );

            console.writeline("XYZ".Length ); // Get the number of characters in the string.
        }
    }
}
