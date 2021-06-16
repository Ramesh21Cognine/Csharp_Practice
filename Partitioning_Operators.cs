using System;
using System.Collections.Generic;
using System.Linq;

namespace Partitioning_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________Take____________________________________");
            //The Take Operator in Linq is used to fetch the first “n” number of elements
            //from the data source where “n” is an integer which is passed as a parameter to the Take method
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string ss = "Take(4)";
            List<int> ResultQS = (from num in numbers
                                  select num).Take(4).ToList();
            //printvalues() method is static method
            printvalue(ResultQS,ss);

            var ResultMS = numbers.Where(num => num > 3).Take(4).ToList();
            string ss1 = "num => num > 3";
                printvalue(ResultMS,ss1);

            Console.WriteLine("\n____________________________________TakeWhile______________________________ ");
            List<int> numbers1 = new List<int>() { 1, 2, 5, 6, 7, 8, 9, 10, 4, 3 };
            List<int> Result1 = numbers1.TakeWhile(num => num < 6).ToList();
            string ss2 = "Result Of TakeWhile Method";
            printvalue(Result1, ss2);
            //n our example, for the first three elements, the condition is true so it fetches the first three elements.
            //When it checks the fourth elements the condition becomes false.
            //So from that point, it will not check the rest of the elements in the data source even though some of the elements
            //(i.e. 4 and 5 present at the end of the collections) satisfying the condition.


            Console.WriteLine("\n___________________________________skip_________________________");
            var skipex = numbers.Where(num => num > 3).Skip(4).ToList();
            string msg = "Result of skip method";
            printvalue(skipex, msg);


            Console.WriteLine("\n______________________________________skipwhile____________________________");
            List<int> skipwhileex = numbers1.SkipWhile(num => num < 5).ToList();
            string msg1 = "skipwhile method result";
            printvalue(skipwhileex, msg);
        }

        static void printvalue(List<int> list,string msg=" ")
        {
            Console.WriteLine();
            Console.Write(msg+"   :  ");
            foreach(var vv in list)
            {
                Console.Write(vv+","+" ");
            }

        }
    }
}
