using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // ### File, FileInfo e IOException

            /*
            string sourcePath = @"C:\Users\moneto\Documents\Cursos\C#\Files\file1.txt";
            string targetPath = @"C:\Users\moneto\Documents\Cursos\C#\Files\file2.txt";            

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            */


            // ### FileStream e StreamReader

            /*
            string path = @"C:\Users\moneto\Documents\Cursos\C#\Files\file1.txt";

            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // fs = new FileStream(path, FileMode.Open);
                // sr = new StreamReader(fs);
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            } 
            finally
            {
                if (sr != null) sr.Close();
                // if (fs != null) fs.Close();
            }
            */


            // ### Bloco using

            /*
            string path = @"C:\Users\moneto\Documents\Cursos\C#\Files\fileX.txt";

            try
            {
                
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}                

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            } 
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }  
            */

            string sourcePath = @"C:\Users\moneto\Documents\Cursos\C#\Files\file1.txt";
            string targetPath = @"C:\Users\moneto\Documents\Cursos\C#\Files\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
