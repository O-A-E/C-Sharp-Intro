using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
           // Logical operatos.
           // OR will evaluate to TRUE if either side is TRUE
           Console.WriteLine ( true || true ); // TURE // || is OR
           Console.WriteLine ( false || true ); // will give true
           Console.WriteLine ( false || false ); // false, both sides have to be false to see false
 
           // AND will evaluate to TRUE only if BOTH sides are true!
           Console.WriteLine (true && true); // TRUE // && is AND
           Console.WriteLine (false && true ); // will give false
           Console.WriteLine ( false && true ); // false

           //How does this behave with different data-types?
           //Console.WriteLine ( true && 1 ); // it doesn't!

           //Comperative operators....
            //"Equal to" check
                Console.WriteLine( false == false ); // one = means it's an assignment! y
                    // two == this will check if something is equal to something
                Console.WriteLine( true == false ); // false
                Console.WriteLine( 2.25 == 2.25 ); // true
                Console.WriteLine ( 2.25 == 3.14 ); //false
                 // Console.WriteLine( 3.14 == "3.14" ); // Cannot check two different types! Will give an error

           // "Greater than" check
                Console.WriteLine( 6 > 7 ); // Fa;se
                Console.WriteLine( 10 > 5); // true

           // "Less than" check
                Console.WriteLine( 6 < 7); // True
                Console.WriteLine( 10 < 5); // false

           // "Greater than or equal to" check
                Console.WriteLine( 5 >= 5); // true
                Console.WriteLine( 10 >= 5); // true
                Console.WriteLine( 4 >= 5); // false

           // "Less than or equal to" check
                Console.WriteLine( 5 <= 5); // true
                Console.WriteLine( 10 <= 5); // false
                Console.WriteLine( 4 <= 5); // true
                // Make sure the operator looks like "<=" not "=>" which is an arrow command for something else!

           // "NOT equal to" check
                Console.WriteLine( false != false ); // false!
                Console.WriteLine( true != false ); // true! 
                Console.WriteLine( 5 != 5 ); // false
                Console.WriteLine( 5 != 10 ); //true

        }
    }
}
