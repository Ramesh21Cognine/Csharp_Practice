using System;
delegate T NumberChanger<T>(T n);

namespace Del
{
    public class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }


    }
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
    }
    class Program : TestDelegate
    {
        static void Main(string[] args)
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            Console.WriteLine("Generic method:");
            //Generic method in non-generic class
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value

            Console.WriteLine("\n \nGeneric class:");

            for (int i = 0; i < 3; i++)
            {
                var x = cities.GetData(i);
                var xx = empIds.GetData(i);
                Console.WriteLine(x);
                Console.WriteLine(xx);

            }


            //Delegates

            Console.WriteLine("\n \nGeneric Delegate:");
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();

        }


    }
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }

}


