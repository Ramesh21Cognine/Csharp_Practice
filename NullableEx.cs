using System;

namespace NullableT
{
    class NullableEx
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;
            int? i = null;
            Console.WriteLine("hello {0}", i);
            i = 5;
            Console.WriteLine("hi2{0}", i);
            i = null;
            Console.WriteLine("i=null {0}", i);
            i = 10;

            Console.WriteLine("i hasvalue is          :{0}", i.HasValue);
            Console.WriteLine("i value is             :{0}", i.Value);
            Console.WriteLine("default value of i is  :{0}", i.GetValueOrDefault());
            Console.WriteLine("i value taype          :{0}", i.GetType());
            Console.WriteLine("i=x                    :{0}", i.Equals(x));
            i = null;
            Console.WriteLine("default value is =     :{0}",i.GetValueOrDefault());
            Console.WriteLine("i=x                    :{0}", i.Equals(x));
        }
    }
}
