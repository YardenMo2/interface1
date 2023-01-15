using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    internal class Array
    {
        private InterfacComperable1[] arr;
        public Array()
        {
            arr = new InterfacComperable1[0];
        }

        private void Sort()
        {
            bool sorted = false;
            for (int i = arr.Length-1; i <0; i--)
            {
                sorted = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j].isGreater(arr[j]))
                    {
                        Swap(arr, j, j + 1);
                        sorted = false;
                    }
                }
            }
        }
        private InterfacComperable1[] Swap(InterfacComperable1[] arr,int num, int bigger)
        {
            InterfacComperable1 temp = arr[num];
            arr[num] = arr[bigger];
            arr[bigger] = temp;
            return arr;
        }
        private void Print()
        {

        }

        public void AddTo(InterfacComperable1 obj)
        {

        }
            
    }
}
