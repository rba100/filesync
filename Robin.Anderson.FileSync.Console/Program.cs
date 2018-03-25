using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobinAnderson.FileSync.Windows;

namespace Robin.Anderson.FileSync.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var winSys = new SystemIoFileSystem();

            var dir = winSys.GetDirectory(@"D:\Data");

            foreach (var file in dir.GetFiles())
            {
                Console.WriteLine($"{file.Path} — {file.LastModifiedUtc}");
            }

            Console.ReadLine();
        }
    }
}
