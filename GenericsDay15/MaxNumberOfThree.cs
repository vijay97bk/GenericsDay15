using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDay15
{
   public class MaxNumberOfThree<T> where T : IComparable
    {
        
            public T Num1, Num2, Num3;
          public T[] arrayNew;
            public MaxNumberOfThree(T Num1, T Num2, T Num3)
            {
                this.Num1 = Num1;
                this.Num2 = Num2;
                this.Num3 = Num3;
            }
            public MaxNumberOfThree()
            {

            }
        public MaxNumberOfThree(T[] arrayNew)
        {
            this.arrayNew = arrayNew;
        }
            public T MaximumOfThree(T Num1, T Num2, T Num3)
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
                    return default;
                }
            }
        public T MaxArray()
        {
            Array.Sort(arrayNew);
            return (arrayNew[arrayNew.Length-1]); 
        }
            public T MaxValue()
            {
                var Max = MaximumOfThree(this.Num1, this.Num2, this.Num3);
                return Max;
            }
        }
}
