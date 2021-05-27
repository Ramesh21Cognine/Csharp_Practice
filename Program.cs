using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary with string key and Int16 value pair    
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Count    
            Console.WriteLine("Count: {0}", AuthorList.Count);
            // Set Item value    
            AuthorList["Neel Beniwal"] = 9;
            if (AuthorList.ContainsKey("Mahesh Chand"))
            {
                AuthorList["Mahesh Chand"] = 20;
            }
            if (AuthorList.ContainsValue(9))
            {
                Console.WriteLine("Item found");
            }
            else
            {
                Console.WriteLine("iteam not found");
            }

            //Read all items 
            Console.WriteLine("Authors all items:");
            Console.WriteLine("-------------------- ");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }

            Console.WriteLine();

            //remove the key and value by useing the key value
            AuthorList.Remove("Dinesh Beniwal");


            // after removing the key value  
            Console.WriteLine("after remove the Dinesh Beniwal ");
            Console.WriteLine("----------------------------------");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }
        

            // Remove all items    
            AuthorList.Clear();

            //count after clear the Dictionary
            Console.WriteLine("Count: {0}", AuthorList.Count);


        }
    }
}
