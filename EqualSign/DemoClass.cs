using System;

namespace Ice.CSharp.Foundation.EqualSign{
    public class DemoClass{
        public static void Execute(){
            // Reference in Program Main Method to Execute
            // primitive type
            int randomNumber  = 10;
            int number1 = randomNumber;
            int number2 = randomNumber;
            Console.WriteLine($"Before update: number1 = {number1}, number2 = {number2}");
            randomNumber = 1000;
            Console.WriteLine($"After update: number1 = {number1}, number2 = {number2}");


            // Reference type
            MyNumberClass randomNumberObj = new MyNumberClass{Result = 10};
            MyNumberClass numberObj1 = randomNumberObj;
            MyNumberClass numberObj2 = randomNumberObj;
            Console.WriteLine($"Before update: numberObj1 = {numberObj1.Result}, numberObj2 = {numberObj2.Result}");
            randomNumberObj.Result = 1000;
            Console.WriteLine($"After update: numberObj1 = {numberObj1.Result}, numberObj2 = {numberObj2.Result}");
            

            // string works like primtive types because it is used extensively, though it is a reference type
            string tempString = "MyTestBeforeUpdate";
            string str1 = tempString;
            string str2 = tempString;
            Console.WriteLine($"Before update: str1 = {str1}, str2 = {str2}");
            tempString = "Update My String";
            Console.WriteLine($"After update: str1 = {str1}, str2 = {str2}");
        }
        private class MyNumberClass{
            public int Result { get; set; }
        }
       
    }

    
}