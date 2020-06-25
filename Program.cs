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
        }


    }
}
