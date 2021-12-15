using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace OOP_HW10
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Задание 1

            #endregion

            #region Задание 2
            //Console.WriteLine(Sum(@"C:\Users\YOGA\Desktop\OOP-10.txt"));
            Sum(@"C:\Users\YOGA\Desktop\OOP-10.txt");
            #endregion

            #region Задание 3

            #endregion

            #region Задание 4

            var path = @"C:\Users\YOGA\Desktop\C# SkillFactory";
            var directories = new List<string>();
            var directoryNames = GetDirectories(new DirectoryInfo(path), directories);

            foreach(var dirName in directoryNames)
                Console.WriteLine(dirName);
            #endregion
        }

        static void Sum(string path)
        {
            var list = File.ReadAllText(path).Split(' ').Select(Convert.ToDouble).ToList();

            Console.WriteLine(list.Sum());
            //using(StreamReader sr = new StreamReader(path))
            //{
            //    var list = sr.ReadToEnd().Split(' ').
            //}
        }
        /// <summary>
        /// Задание 4
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static string[] GetDirectories(DirectoryInfo directory, List<string> directoryNames)
        {
            //var directoryNames = new List<string>();

            foreach (var dir in directory.GetDirectories())
            {
                directoryNames.Add(dir.FullName);
                GetDirectories(dir, directoryNames);
            }

            return directoryNames.ToArray();
        }
    }
}
