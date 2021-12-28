using System;

namespace List_dav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList<int> i = new MyList<int>();

            i.show();
            i.Add(1, 0);
            i.Add(2, 1);
            i.Add(3, 2);
            i.show();

            i.Delete(0);
            i.show();

            Console.WriteLine($"number of elements: {i.Count()}");

            Console.WriteLine($"Element by index:  index = 1 & element= {i.ElementByIndex(1)}");
            //Console.WriteLine($"Element by index:  index = 5 & element= {i.ElementByIndex(5)}");
        }
    }
}
