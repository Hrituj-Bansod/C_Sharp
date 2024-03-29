using System;
using System.Collections.Generic;
using System.Text;

namespace LINQQ
{
    public class Student
    {
        public int id;
        public string name;
        public string subject1;
        public string subject2;

        public override string ToString()
        {
            return $" ID : {id} ,\n Name : {name} ,\n Subject1 : {subject1} ,\n Subject2 : {subject2}\n";
        }
    }
}
