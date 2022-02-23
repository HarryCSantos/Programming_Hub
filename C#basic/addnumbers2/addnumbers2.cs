using System;
using System.Collections;

namespace ArrayListExample
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            //creating arraylist
            ArrayList al= new ArrayList();

            //adding object in arraylist
            al.Add("Java");
            al.Add("C");
            al.Add("C++");
            al.Add("PHP");

            Console.Write("Contents of ArrayList: ");

            //Using Enhance for-loop
            foreach(String str in al)
            {
                Console.Write( str);
            }
            Console.ReadLine();
        }
    }
}