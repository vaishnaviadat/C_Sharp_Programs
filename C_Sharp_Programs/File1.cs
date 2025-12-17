using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    
namespace C_Sharp_Programs
{
    internal class File1
    {
        static void Main(string[] args)
        {
            //------------File Exits or not-------------------
            //string path= @"C:\File\f1.txt";//verbatim string literal
            //string path1 = @"C:\File\f3.txt";//verbatim string literal

            //if (File.Exists(path1))
            //{
            //    Console.WriteLine("File Exists");
            //}
            //else
            //{
            //    Console.WriteLine("File does not Exists");
            //}
            //---------------------------------------------------------------------------------------------------------------------------//

            //------------File Read All data from text file-------------------
            //string path = @"C:\File\f1.txt";//verbatim string literal
            //string path = @"C:\File\f2.txt";//verbatim string literal
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File Exists");
            //    string data = File.ReadAllText(path);
            //    Console.WriteLine("-----Data from file is---------\n" + data);
            //}
            //else {
            //    Console.WriteLine("File does not Exists");
            //}

            //---------------------------------------------------------------------------------------------------------------------------//
            //------------Copy file data from one file to another file-------------------
            //string path3 = @"C:\File\f1.txt";//verbatim string literal
            //string path4 = @"C:\File\File2\f4.txt";//verbatim string literal
            //if(File.Exists(path3))
            //{
            //    Console.WriteLine("File Found");
            //    File.Copy(path3, path4,true);
            //}
            //else {
            //    Console.WriteLine("File Not Found");

            //}

            //---------------------------------------------------------------------------------------------------------------------------//
            //------------Create,Read,Move,Delete Directory Class-------------------
            //string dirpath = @"C:\folder2";//verbatim string literal
            //DirectoryInfo dir = new DirectoryInfo(dirpath);
            //dir.Create();
            //dir.CreateSubdirectory("Another_Folder");
            //Console.WriteLine("Directory Created");

            //---------------------------------------------------------------------------------------------------------------------------//
            //------------Move files from Directory-------------------
            string path1 = @"C:\folder2";
            string path2 = @"C:\folder4";
            DirectoryInfo dir = new DirectoryInfo(path1);
            dir.MoveTo(path2);
            Console.WriteLine("Moved Dir");

            //----------------------------------------------------------------------------------------------------------------------------//
            //----------Get Directory--------------------
            //string path = @"C:\new";
            //DirectoryInfo dir = new DirectoryInfo(path);
            //DirectoryInfo[] dirs = dir.GetDirectories();
            //foreach(var i in dirs)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(i.FullName);
            //    Console.WriteLine(i.GetFiles().Length);
            //}
            //string path2 = @"C:\new\n1";
            //DirectoryInfo dir2 = new DirectoryInfo(path2);
            //Console.WriteLine(dir2.Name);
            //Console.WriteLine(dir2.FullName);
            //Console.WriteLine(dir2.LastAccessTime);
            //Console.WriteLine(dir2.CreationTime);
            //Console.WriteLine(dir2.Attributes);
            //Console.WriteLine(dir2.Parent);
            //Console.WriteLine(dir2.Root);
            //Console.WriteLine(dir2.LastWriteTime);

            Console.ReadLine();
        }
    }
}
