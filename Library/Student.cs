using System;

namespace Ice.CSharp.Foundation.Library
{
    public class Student{
        // Property
        public int Id { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        public DateTime Birthday { get; set; }

        // Constructor
        public Student(){
            Console.WriteLine($"Student class: The constructor of {typeof(Student)} class is called.");
        }
      
        // Method
        public void Borrow(string Book){
            // Do something with the borrowed book
            Console.WriteLine($"Student class: The borrow method in the Student class is called.");
        }
        
    }
}