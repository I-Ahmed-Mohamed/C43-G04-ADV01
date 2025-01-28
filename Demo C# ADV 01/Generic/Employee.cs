using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__ADV_01.Generic
{
    internal struct Employee
    {

        public int Id {  get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        #region Operator Oveloading

        public static bool operator == (Employee left, Employee right)
        {
            // left.id == Right.id
            // left.Name == Right.Name
            // left.Salary == Right.Salary


            //return  (left.Id  == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary);

            return left.Equals (right) ;
        }



        #region q1
        public static bool operator !=(Employee left, Employee right)
        {
            // left.id != Right.id
            // left.Name != Right.Name
            // left.Salary != Right.Salary

            //return (left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary);

            return !left.Equals(right); 
            #endregion

        }

        #endregion
    }
}
