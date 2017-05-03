using System;

namespace Ice.CSharp.Foundation.ConsoleRead{
    public class ConsoleReader{
        public static void Execute(){
            Console.WriteLine("Please type in an integer.");
            
            if(int.TryParse(Console.ReadLine(), out int number)){
                Console.WriteLine($"You have typed in {number}");
            }else{
                Console.WriteLine($"Your input is not a valid integer");
            }
        }        
    }
}
