using System.Collections.Generic;
using System;
using System.Linq;
namespace LINQDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 102, Name = "Sambit"},
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 101, Name = "Preety" },
            };

            return students;
        }

        public override bool Equals(object obj)
        {
            //As the obj parameter type id object, so we need to
            //cast it to Student Type
            return this.ID == ((Student)obj).ID && this.Name == ((Student)obj).Name;
        }

        public override int GetHashCode()
        {
            //Get the ID hash code value
            int IDHashCode = this.ID.GetHashCode();

            //Get the string HashCode Value
            //Check for null refernece exception
            int NameHashCode = this.Name == null ? 0 : this.Name.GetHashCode();

            return IDHashCode ^ NameHashCode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var MS = Student.GetStudents()
                    .Select(std => new { std.ID, std.Name })
                    .Distinct().ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      select std)
                      .Select(std => new { std.ID, std.Name })
                      .Distinct().ToList();
            foreach (var item in MS)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }
            Console.ReadKey();
        }
    }
}