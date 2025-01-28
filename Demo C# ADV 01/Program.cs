using Demo_C__ADV_01.Generic;
using System.Drawing;

namespace Demo_C__ADV_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics  [SWAP Example]
            //int A = 1, b = 2;
            //Console.WriteLine($"A = {A}"); // 1 
            //Console.WriteLine($"b = {b}"); // 2 
            //Helper<int>.SWAP(ref A, ref b);
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"A = {A}"); // 2
            //Console.WriteLine($"b = {b}"); // 1




            //double p = 2.3, o = 2.4;
            //Console.WriteLine($"p = {p}"); // 2.3 
            //Console.WriteLine($"o = {o}"); // 2.4 
            //Helper<double>.SWAP(ref A, ref b);
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"p = {p}"); // 2.4
            //Console.WriteLine($"o = {o}"); // 2.3


            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(10, 20);
            //Console.WriteLine(P01); // 1,2
            //Console.WriteLine(P01); // 10,20
            //Helper<Point>.SWAP(ref P01, ref P02); // invalid
            //Console.WriteLine(P01); // 10,20
            //Console.WriteLine(P01); // 1,2







            #endregion

            #region Generic [ Serch Example ]
            //int[] Numbers = { 4, 5, 6, 7, 8, 9, 10, 1, 3, 2 };

            //int index = Helper.SerchArray(Numbers, 2);
            //Console.WriteLine($"index of 6 is {index}");


            //if (E01 == E02) Console.WriteLine("Equal");
            //else Console.WriteLine("Not Equal");


            //if (E01.Equals(E02)) Console.WriteLine("Equal");
            //else Console.WriteLine("Not Equal");

             

            // Employee E01 = new Employee() {Id = 10 , Name = "Ahmed" , Salary = 25000 };
            // Employee E02 = new Employee() { Id = 20, Name = "Rawan", Salary = 30000 };

            //Employee E03 = new Employee() { Id = 20, Name = "Esam", Salary = 35000 };


            //Employee[] employees = new Employee[2];
            //{
            //    E01 ,  E02
            //};

            //int index =  Helper<Employee>.SerchArray(employees, E03);
            //Console.WriteLine(index);

            #endregion


        }
    }
}
