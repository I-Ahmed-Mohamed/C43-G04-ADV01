using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__ADV_01
{
    // Generic Class 
    // in case Generic Type <T> is Declared on  class Or Struct Or interface 
    // Compiler Can not  Detect T Type Of T 
    internal class Helper<T>
    {
        //T Salary { get; set; } // invalid    
        #region Non Genarics


        //public static void SWAP (ref int x, ref  int y)
        //{
        //    int Temp = x;
        //    x = y ;
        //    y = Temp;
        //}


        //public static void SWAP(ref double x, ref double y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}


        //public static void SWAP(ref Point x, ref Point y)
        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;
        //}


        //public static int SerchArray(int[] array , int value)
        //{
        //    if (array is not null)
        //    {
        //        for(int i = 0; i < array.Length; i++)
        //        {
        //            if (value == array[i])
        //            {
        //                return i; 
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Genarics
        // T => Generic Type 
        // SWAP => Generic Method 
        // in case Generic Type <T> is Declared on Method Level , Not class Or Struct Or interface 
        // Compilre Can Detect T Type Of T Based Of Passed Parameter  




        //public static int SerchArray(T[] array, T value)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (value.Equals(array[i]))
        //            {
        //                return i;
        //            }
        //        }
        //        return -1;
        //    }
        //}




        //public static void SWAP<T>(ref T x, ref T y)
        //{
        //    T Temp = x;
        //    x = y;
        //    y = Temp;
        //}


        #endregion



    }
}
