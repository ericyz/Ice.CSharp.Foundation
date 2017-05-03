
using System;

namespace Ice.CSharp.Foundation.Library
{
    public class Simulator{
         public static void Execute(){
              Student student = new Student();
            Console.WriteLine("Main Method: student has been initlized");
            student.Borrow("A Brief History of Time");
            Console.WriteLine("Main Method: student has been initlized");
        }
    }
}