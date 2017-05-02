using System;

namespace Ice.CSharp.Foundation.LuckNumber{
    public class LuckNumber{
        private static Random random = new Random(10);

        public static void Execute(){
            int number;
            if(IsLuckNow()){
                number = GetMyLuckyNumber();
            }else{
                number = GetMyUnluckyNumber();
            }
        }

        private static bool IsLuckNow(){
            return random.Next() < 10;
        }

        private static int GetMyLuckyNumber(){
           return 7;
        }

        private static int GetMyUnluckyNumber(){
          return 13;
        }
    }
}