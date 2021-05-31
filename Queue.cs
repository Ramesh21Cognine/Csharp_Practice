using System;
using System.Collections;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue("Welcome");
            que.Enqueue("to");
            que.Enqueue("stack");
            que.Enqueue("programs");
            que.Enqueue("as well");
            que.Enqueue(20.5f);
            que.Enqueue(10);
            que.Enqueue(100);
            PrintValues(que);
            Console.WriteLine(que.IsSynchronized);//its synchronized its true otheerwise false

            Console.WriteLine("Count:    {0}", que.Count);  //count the number of elements in queue

            //cone the queue 
            Queue que2 = (Queue)que.Clone();
            Console.WriteLine("**********************que2************************");
            PrintValues(que2);

            //contains method
            Console.WriteLine(que2.Contains("programs"));//it contains it will return true otherwise false

            //Queue copyto array
            Console.WriteLine("copy queue into array");
            Object[] myStandardArray = que.ToArray();
            PrintValues(myStandardArray, ' ');
            Console.WriteLine(myStandardArray.GetType());
            Console.WriteLine(myStandardArray);


            Console.WriteLine("*********************Dequeue and Enqueue**************************** ");
            PrintValues(que2);
            var v=que2.Dequeue();
            PrintValues(que2);
            que2.Enqueue(v);
            PrintValues(que2);


            Console.WriteLine("*************peek************");
            Console.WriteLine(que2.Peek());
            PrintValues(que2);


            Console.WriteLine("********************clear******************");
            que2.Clear();
            Console.WriteLine("count of the queue {0}  ",que2.Count);
            PrintValues(que2);
            

            Console.WriteLine("hash code of program {0}",que2.Contains(100).GetHashCode());
           
            


        }
        //printing the values of queue
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        //printing the values of array
        public static void PrintValues(Array myArr, char mySeparator)
        {
            foreach (Object myObj in myArr)
            {
                Console.Write("{0}{1}", mySeparator, myObj);
            }
            Console.WriteLine();
        }
    }
}
