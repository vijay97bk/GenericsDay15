using System;

namespace GenericsDay15
{
     public class CheckMaxOfThree
    {
        public int MaximumOfThree(int Num1, int Num2, int Num3)
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 ||
               Num1.CompareTo(Num2) >= 0 && Num1.CompareTo(Num3) > 0 ||
               Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) >= 0)
               {
                return Num1;
               }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0 ||
               Num2.CompareTo(Num1) >= 0 && Num2.CompareTo(Num3) > 0 ||
               Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) >= 0)
               { 
                return Num2;
               }
            if (Num3.CompareTo(Num2) > 0 && Num3.CompareTo(Num2) > 0 ||
               Num3.CompareTo(Num2) >= 0 && Num3.CompareTo(Num2) > 0 ||
               Num3.CompareTo(Num2) > 0 && Num3.CompareTo(Num2) >= 0)
               {
                return Num3;
               }
            {
                return Num1;
            }
        }
        static void Main(string[] args)
        {
            CheckMaxOfThree checkMaxOfThree = new CheckMaxOfThree();
            checkMaxOfThree.MaximumOfThree(10, 20, 30);
        }
    }
}
