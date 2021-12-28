using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_dav
{
    class MyList<T>
    {
        static int Capacity = 1000;
        T[] myarr = new T[Capacity];
        private int MySize;

        public MyList()
        {
            MySize = 0;
        }

        public bool isEmpty() { return MySize==0; }
        public void Delete(int position) {
            if (isEmpty())
            {
                Console.WriteLine("!!!List is empty !!!");
            }else if (position < 0 || position >= MySize)
            {
                Console.WriteLine("!!! Wrong position !!!");
            }
            else
            {
                for(int i = position; i < MySize; i++)
                {
                    myarr[i] = myarr[i + 1];
                }

                MySize--;
            }
        }
        public void Add(T element, int position) {
            if (MySize == Capacity ||(position < 0 || position > MySize))
            {
                Console.WriteLine("!!! No space for list element or wrong position !!!");
            }else
            {
                for(int i = MySize; i > position; i--)
                {
                    myarr[i] = myarr[i - 1];
                }
                myarr[position] = element;
                MySize++;
            }
        }
        public int Count() { return MySize; }
        public T ElementByIndex(int index) {
            if (index < 0 || index > MySize - 1)
            {
                Console.WriteLine("!!! wrong index !!!");
                return myarr[-1];
            }
            else
            {
                return myarr[index];
            }
        }
        public void show() {
            for (int i= 0;i < MySize;i++)
            {
                if (i % 5 == 0) Console.WriteLine();
                Console.Write($"{myarr[i]}    ");      
            }
        }

    }
}
