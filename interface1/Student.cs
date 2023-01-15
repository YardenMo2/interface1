using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    internal class Student : InterfacComperable1
    {
        private int id;
        private List<int> grades;

        public Student(int id)
        {
            this.id = id;           
        }

        public bool isEquel(object obj)
        {
            return false;
        }

        public bool isGreater(object obj)
        {
            return false;
        }
    }
}
