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
            Sum(@"C:\Users\YOGA\Desktop\OOP-10.txt");
            #endregion

            #region Задание 3 ✔
            //CreateFile();
            //ChangeFile();
            //Для проверки можно закомментировать второй метод
            #endregion

            #region Задание 4 ✔
            //var path = @"C:\Users\YOGA\Desktop\C# SkillFactory";
            //var directories = new List<string>();
            //var directoryNames = GetDirectories(new DirectoryInfo(path), directories);

            //foreach(var dirName in directoryNames)
            //    Console.WriteLine(dirName);
            #endregion
        }
        //--------------------------------------------------------
        //Задание 1

        //--------------------------------------------------------
        //Задание 2
        static void Sum(string path)
        {
            var list = File.ReadAllText(path).Split().Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => double.TryParse(x, out double y));
            foreach(var number in list)
                Console.WriteLine(number);
            //using(StreamReader sr = new StreamReader(path))
            //{
            //    var list = sr.ReadToEnd().Split(' ').
            //}
        }
        //--------------------------------------------------------
        //Задание 3 ✔
        static IEnumerable<long> Fibonachi()
        {
            int flag = 0;
            long a = 0;
            long b = 1;
            long c;
            yield return 0;
            yield return 1;
            while (flag < 8)
            {
                c = a + b;
                yield return c;
                flag++;
                a = b;
                b = c;
            }
        }
        static void CreateFile()
        {
            var fileName = @"C:\Users\YOGA\Desktop\numbers.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var number in Fibonachi())
                    sw.WriteLine(number);
            }
            foreach(var number in File.ReadAllLines(fileName))
                Console.WriteLine(number);
        }

        static void ChangeFile()
        {
            var fileName = @"C:\Users\YOGA\Desktop\numbers.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var number in Fibonachi())
                    sw.WriteLine(number * number);
            }
            foreach (var number in File.ReadAllLines(fileName))
                Console.WriteLine(number);
        }
        //--------------------------------------------------------
        //Задание 4 ✔
        static string[] GetDirectories(DirectoryInfo directory, List<string> directoryNames)
        {
            foreach (var dir in directory.GetDirectories())
            {
                directoryNames.Add(dir.FullName);
                GetDirectories(dir, directoryNames);
            }

            return directoryNames.ToArray();
        }
    }
}
