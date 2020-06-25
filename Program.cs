using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
         // It is a good idea for user experience to prome the user
         // guiding the user is great as it tells them what is expected   
            
            Console.Writeline( "Please enter a string");
            string userInput = Console.Readline(); // Assignment; collecting data from user

            // We can use if statemnts to check a condition
            //if the if statment is ture, its code block marked by curly bcares {} will execute

          if ( userInput.Length > 0 )
          {
              Console.Writeline( "User entered a value" );
              // if there is an else statement proceeding an if, it will only execute if the if statement itself was false

          }
          else 
          {
              Console.Writeline( "User did not enter a value" );

          }
        }
    }
}
