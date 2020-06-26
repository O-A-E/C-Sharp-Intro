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
                                { "dolphin", "octopus", "shark", "whale" } };
            // We can use a foreach to iterate through the list of lists, one list at a time
            // the datatype we expect is the "string[]"
            
            foreach( string topic in topics )
                {
                    {
                        // the output is the current animal!
                        Console.WriteLine( "This animal is: {0}", topic );
                    }
                
                    
                }   
            
        }


    }
}

