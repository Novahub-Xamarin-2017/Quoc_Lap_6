using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ex4solution
{
    class Program
    {
        private static List<string> FilterFile(string path, Func<string, bool> filter)
        {
            var filterdFiles = new List<string>();
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (filter(file))
                {
                    filterdFiles.Add(file);
                }
            }
            return filterdFiles;
        }
        static void Main(string[] args)
        {
            var allDocs = FilterFile(@"C:\Users\Steven\Desktop\XAMARIN MOVAHUB",x=>x.EndsWith(".docx"));
            allDocs.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
