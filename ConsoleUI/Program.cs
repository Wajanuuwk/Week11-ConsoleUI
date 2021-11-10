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
        static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            
            Console.ReadLine();
        }
    }
}
