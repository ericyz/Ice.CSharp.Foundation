using System;
using Ice.CSharp.Foundation.ConsoleRead;
using Ice.CSharp.Foundation.EqualSign;
using Ice.CSharp.Foundation.Library;

namespace Ice.CSharp.Foundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Main Method: student has been initlized");
            student.Borrow("A Brief History of Time");
            Console.WriteLine("Main Method: student has been initlized");
            
        }
    }
}
