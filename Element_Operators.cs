using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Element_Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //ElementAt

            Console.WriteLine("______________________________ElementAt_______________________________");
            //The ElementAt operator is used to return an element from a specific index.
            //Throws ArgumentOutOfRange Exception in case of specific index out of range.

            int MethodSyntax = numbers.ElementAt(1);
            Console.WriteLine(MethodSyntax);

           var eleat1 = (from num in numbers
                                select num).ElementAt(1);
            Console.WriteLine(eleat1);
            try
            {
                Console.WriteLine(numbers.ElementAt(10));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
    


            // ElementAtOrDefault
            Console.WriteLine("\n________________________________ElementAtDefault______________________________");
            //Returns a default value in case the specific index is out of range.
            Console.WriteLine(numbers.ElementAtOrDefault(8));
            Console.WriteLine($"index out of range so it returns default value without any exceptioins {0}    :     ",numbers.ElementAtOrDefault(15));
            var eleat2= (from num in numbers
                                select num).ElementAtOrDefault(99);
            Console.WriteLine(eleat2);


            //First
            Console.WriteLine("\n__________________________________First__________________________________________");
            //The Linq First Method is used to return the first element from a data source
            //Throws invalidOperationException in case of it's failed with condition
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.First(num => num > 5));
            Console.WriteLine(numbers.First(num => num % 2 == 0));

            var first1 = (from num in numbers
                                select num).First(num => num % 2 == 0);
            Console.WriteLine(first1);
            //Console.WriteLine(numbers.First(num => num > 50));  => throws exception

            Console.WriteLine("\n_______________________________________FirstOrDefault_________________________________");
            //it returns a default value of a specified generic type, instead of throwing an exception if no element found for the specified condition.
            //Returns Null in case it's failed with condition
            Console.WriteLine(numbers.FirstOrDefault());
            Console.WriteLine(numbers.FirstOrDefault(num => num>500));

            
            var first2 = (from num in numbers
                                select num).FirstOrDefault();
            
            Console.WriteLine(first2);


            Console.WriteLine("\n_______________________________________Last_____________________________________________");
            //The Last Method in Linq is used to return the last element from a data source
            //InvalidOperationException in case of sequence contain no element
            Console.WriteLine(numbers.Last());
            Console.WriteLine(numbers.Last(num => num%2 ==0));
            Console.WriteLine(numbers.Last(num => num%4 ==0));

            var last1 = (from num in numbers
                                select num).Last();
            Console.WriteLine(last1);

            Console.WriteLine("\n______________________________________LastOrDefault______________________________________");
            //it returns a default value of a specified generic type, instead of throwing an exception if no element found for the specified condition.
            Console.WriteLine(numbers.LastOrDefault());
            Console.WriteLine(numbers.LastOrDefault(num => num>11));

            var last2 = (from num in numbers
                                select num).LastOrDefault();
            Console.WriteLine(last2);


            Console.WriteLine("\n_____________________________________________Single___________________________________________");

            //The Linq Single Method is used to returns a single element from a data source or you can say from a sequence.
            //Exception occured in these three conditions
            //  1) If the data source is empty.
            //  2)When the given condition does not satisfy any element in the sequence.
            //  3)If the given condition satisfies more than one element.
           Console.WriteLine(numbers.Single(num => num==5));

            var single1 = (from num in numbers
                           select num).Single(num => num == 5);
            Console.WriteLine(single1);

            Console.WriteLine("\n______________________________________________SingleOrDefault____________________________________");
            //it returns a default value of a specified generic type, instead of throwing an exception if no element found for the specified condition.
            //System.InvalidOperationException: 'Sequence contains more than one matching element'
            //Console.WriteLine(numbers.SingleOrDefault(num => num%2 ==0));
            Console.WriteLine(numbers.SingleOrDefault(num => num>10));

            var single2 = (from num in numbers
                           select num).SingleOrDefault(num => num > 10); 
            Console.WriteLine(single2);

        }
    }
}
