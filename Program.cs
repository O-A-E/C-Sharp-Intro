using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a list of type string, and multiple lists: lists within lists
            // multiple pieces of variables
            // these are 4 strings within a list
            // this is a 2 dimensional array!
           string [,] topics = { { "cat", "dog", "frog", "hedgehog"}, 
                                { "zebra", "giraffe", "lion", "elephant"},
                                { "dolphin", "octopus", "shark", "whale" }, 
                                { "ant", "beetle", "waterbug", "mosquito" }};
            // We can use a foreach to iterate through the list of lists, one list at a time
            // the datatype we expect is the "string[]"
            // Loop through the rows...
            for( int row = 0; row < topics.GetLength(0); row++ ) // row = row + 1
             {
                // Output current row...
                Console.WriteLine( "Starting row #{0}", row );
                // Loop through columns in the current row...
                for ( int column = 0; column < topics.GetLength(1); column++ )
                {
                    // Output the current column...
                    Console.WriteLine( "Starting column #{0}", column );
                    // Output the current animal!
                    Console.WriteLine( "This animal is: {0}", topics[row,column] );
                }
             }
    }
}}
