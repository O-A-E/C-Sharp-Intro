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
        }
    }
}
