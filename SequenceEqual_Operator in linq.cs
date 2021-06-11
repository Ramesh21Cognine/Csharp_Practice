using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceEqual_Operator
{

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetStudents1()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
        public static List<Student> GetStudents2()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
    }

    //Creating Custom StudentComparer class for comparing the student complex type
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.ID == y.ID && x.Name == y.Name;
        }
        public int GetHashCode(Student obj)
        {
            return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            List<string> cityList2 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            List<string> cityList3 = new List<string> { "delhi", "MUMBAI", "Hyderabad" };
            List<string> cityList4 = new List<string> { "Delhi", "Hyderabad", "Mumbai" };


            bool IsEqual = cityList1.SequenceEqual(cityList2);
            Console.WriteLine(IsEqual);

            //comparison to be case-insensitive,
            bool strcmpr = cityList1.SequenceEqual(cityList3, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(strcmpr);

            //the data are not present in the same order in both the sequences.
            bool strorder = cityList1.SequenceEqual(cityList4, StringComparer.OrdinalIgnoreCase);

            bool orderby = cityList1.OrderBy(city => city)
                   .SequenceEqual(cityList2.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(strorder);
            Console.WriteLine(orderby);

            //Both the sequence contains the same data but here we are getting the output as False. This is because when comparing the complex types,
            //the default comparer which is used by the SequenceEqual method will only check if the object references are equal or not.
            List<Student> StudentList1 = Student.GetStudents1();
            List<Student> StudentList2 = Student.GetStudents2();


            bool IsEqual1 = StudentList1.SequenceEqual(StudentList2);
            Console.WriteLine(IsEqual1);

            //anonymoustype comparision for complex type
            var Anonymoustype = StudentList1
                    .Select(std => new { std.ID, std.Name })
                    .SequenceEqual(StudentList2.Select(std => new { std.ID, std.Name }));
            Console.WriteLine(Anonymoustype);

            //useing custom StudentComparer for complex type
            StudentComparer studentComparer = new StudentComparer();
            bool custcmpr = StudentList1.SequenceEqual(StudentList2, studentComparer);
            Console.WriteLine(custcmpr);
        }
    }
}
