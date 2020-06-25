using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 3; 
            while ( myNum > 0 ) // iterates or loops while the CONDITION si TRUE.
            {
                Console.WriteLine( "Current number is: {0}", myNum );
                myNum--;
                //everything in these curly braces will continue to run while the condition is true
                //myNum--the "--"  will reduce the output by one
                //myNum++ the "++ will increase the outout by one

                //purpose of loops is for any time we need an action to repeat!
            }

            /* For loops always have 3 componentssemi-colon components:
                    1) we have an assignment
                    2) [Termination] condition
                    3) Iteration. (for example ( i += 2) )

                for loops keep your code tidy!
                
                integer starts at 0, each time it loops, it checks the 
                first condition to see if it's true or false
                if i > 6, it will loop again and run the code block and interate

            
            */
            for ( int i = 0; i < 6; i += 2 )
                    // += means it will add 2 to the original value each step!
            {
                Console.WriteLine( "current (for) number is: {0}", i );
            }
        
        // [] tells program to create more than one string. We are assigning more than one string
        // If we need to iterate through a list, use foreach!
        // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
         

        string [] myList = { "cat", "turtle", "lizard", "frog", "dog" };
        // { } show the start and end of our list
        // each type of animal is a string
        // this type of loop is read-only, so you can't change the animal name "cat" to "ant"
        // would need a different loop command to do this

        foreach ( string listItem in myList )
        // For each item, there will be a string in my list
        {
            Console.WriteLine( "The current item is: {0}", listItem );
        }

        }


    }
}
