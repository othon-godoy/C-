using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory e DirectoryInfo

            /*
            string path = @"C:\Users\moneto\Documents\Cursos\C#\Directories";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                // var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);               

                Console.WriteLine("Files: ");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */


            // ### Path
            string path = @"C:\Users\moneto\Documents\Cursos\C#\Directories\file1.txt";

            Console.WriteLine("DirectorySeparatorChar:" + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator:" + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName:" + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension:" + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension:" + Path.GetExtension(path));
            Console.WriteLine("GetFullPath:" + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath:" + Path.GetTempPath());
        }
    }
}
