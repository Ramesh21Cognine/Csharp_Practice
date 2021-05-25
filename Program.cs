using System;
using System.Collections;

namespace stackex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            PrintValues(myStack);

            Console.WriteLine(myStack.Contains("Hello"));
            Console.WriteLine(myStack.Peek());
            var popp = myStack.Pop();
            Console.WriteLine(popp);
            Console.WriteLine(myStack.GetType());
            Console.WriteLine("*****get every element *****tostring ********  type  ******* hashcode*******  ");
            foreach ( object ss in myStack)
            {
                Console.WriteLine(ss.ToString());
                Console.WriteLine(ss.GetType());
                Console.WriteLine(ss.GetHashCode());

            }
            Stack stackcopy = (Stack)myStack.Clone();
            Console.WriteLine("**************Cloned stack**********");
            PrintValues(stackcopy);

            Console.WriteLine($"enmuerator {myStack.GetEnumerator()}");
            Console.WriteLine($"type  {myStack.GetType()}");
            Console.WriteLine($"Peek  {myStack.Peek()}");
            Console.WriteLine($"POP   {myStack.Pop()}");
            PrintValues(myStack);
            myStack.Clear();
            Console.WriteLine("cleared the my stack");
            myStack.Push("cleared stack");
            PrintValues(myStack);

           
        }

   public static void PrintValues( IEnumerable myCollection )  {
      foreach ( Object obj in myCollection )
         Console.Write( "    {0}", obj );
      Console.WriteLine();
   }
    }
}
