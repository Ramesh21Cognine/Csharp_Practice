using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
       // private const string Value = "Directory       ";

        static void Main(string[] args)
        {
            string rootPath = @"E:\Ramesh\Dictionary\obj\Release\netcoreapp3.1";

            string destinationFolder = @"E:\Ramesh\Dictionary\obj\Release\netcoreapp3.1\createdbyprogram";

            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);//AllDirectories also get the subdirectories of the dirrectory
																								 //TopDirectoryOnly get the only on the directory

           // foreach (string dir in dirs)
           // {
           //     Console.Write("directory   ");
           //     Console.WriteLine(dir);
           // }

           //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

           //foreach (string file in files)
           //{
           //     Console.Write("file     :   ");
		   
           //     Console.WriteLine(file);                                     //get the full path of the file
		   
           //     Console.WriteLine(Path.GetFileName(file));                  //get the file name with extension
		   
           //     Console.WriteLine(Path.GetFileNameWithoutExtension(file)); //get the file name without extension
		   
           //     Console.WriteLine(Path.GetDirectoryName(file));            //directory of the file ex:"E:\Ramesh\Dictionary\obj\Release\netcoreapp3.1  the file in the netcoreapp3.1
           //     var info = new FileInfo(file);

           //     Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");  //it prints file name with its size
           //}

           // string newPath = @"E:\Ramesh\Dictionary\obj\Release\netcoreapp3.1\createdbyprogram";
           //Directory.CreateDirectory(newPath);
           // bool directoryExists = Directory.Exists(newPath);

           // if (directoryExists)
           // {
           //     Console.WriteLine("The directory exists");
           // }
           // else
           // {
           //     Console.WriteLine("The directory does not exist so it is created");
           //     Directory.CreateDirectory(newPath);
           // }

           string[] filess = Directory.GetFiles(@"E:\Ramesh\Dictionary\obj\Release");//all files in this  path are in the filess array[] 
            //foreach(string file in filess)
            //{
            //    File.Copy(file, $"{destinationFolder}{ Path.GetFileName(file)}",true);//there true is accepts the file override;
            //    Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)}   is copied to destination folder");
            //}
            
        for (int i = 0; i < filess.Length; i++)
        {
            File.Copy(filess[i], $"{destinationFolder} { i }.txt", false);//there override is not accepts 
        }

        //foreach (string file in files)
        //{
        //    File.Move(file, $"{destinationFolder}{ Path.GetFileName(file) }");
        //}

        // var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

        // foreach (string file in files)
        //  {
        //Console.WriteLine(file);
        //Console.WriteLine(Path.GetFileName(file));
        //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
        //Console.WriteLine(Path.GetDirectoryName(file));
        //var info = new FileInfo(file);

        //Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");
        // }

        Console.ReadLine();
        }
    }
}
