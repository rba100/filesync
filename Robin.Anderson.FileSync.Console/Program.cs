using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RobinAnderson.FileSync.Core;
using RobinAnderson.FileSync.Interfaces;
using RobinAnderson.FileSync.Windows;

namespace Robin.Anderson.FileSync.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileSystem winSys = new SystemIoFileSystem();
           // var dir = winSys.GetFileSet(@"D:\Data");
            var dir = winSys.GetFileSet(@"D:\nvidia");
            var root = dir.Root;

            RecursiveNav(root);

            Console.ReadLine();
        }

        private static int depth = 0;

        static void RecursiveNav(IDirectory directory)
        {
            foreach (var file in directory.Files)
            {
                Indent(file.Name);
            }
            foreach (var subdir in directory.Directories)
            {
                Indent(subdir.PathFromRoot);
                depth++;
                RecursiveNav(subdir);
                depth--;
            }
        }

        static void Indent(string msg)
        {
            Console.WriteLine(new String(' ', depth*4) + msg);
        }
    }
}
