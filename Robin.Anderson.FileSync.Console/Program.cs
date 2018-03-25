using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RobinAnderson.FileSync.Core;
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
                using (var hashProvider = new HashProvider(file.Open(), new SHA1CryptoServiceProvider()))
                {
                    var hash = BitConverter.ToString(hashProvider.Hash);
                    Console.WriteLine($"{file.Path} — {file.LastModifiedUtc} ({hash})");
                }
            }

            Console.ReadLine();
        }
    }
}
