using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Problem_4._Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<File> files = new List<File>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] fileArgs = input.Split(new char[] { '\\',';'});
                string currnetRoot = fileArgs[0];
                
                string currentExtens = fileArgs[fileArgs.Length - 2].Split('.').Last();
                string currentName = string.Join(".",fileArgs[fileArgs.Length - 2].Split('.').Take(fileArgs[fileArgs.Length - 2].Split('.').Length - 1));
                BigInteger currentSize = BigInteger.Parse(fileArgs[fileArgs.Length - 1]);
                int index = files.FindIndex(x => x.Path == currnetRoot && x.Name == currentName && x.Extennsion == currentExtens);
                if (index != -1)
                {
                    files[index].Size = currentSize;
                    continue;
                }
                files.Add(new File(currentName, currentExtens, currentSize, currnetRoot));
            }

            string[] commandOutput = Console.ReadLine().Split(' ');
            string ext = commandOutput[0];
            string folder = commandOutput[2];
            List<File> filesEx = files.Where(x => x.Path == folder && x.Extennsion == ext).ToList();
            if (filesEx.Count() == 0)
            {
                Console.WriteLine("No");
                return;
            }
            foreach (var file in filesEx.OrderByDescending(y => y.Size).ThenBy(c => c.Name))
            {
                Console.WriteLine($"{file.Name}.{file.Extennsion} - {file.Size} KB");
            }
        }
    }
    class File
    {
        public string Name { get; set; }
        public string Extennsion { get; set; }
        public BigInteger Size { get; set; }
        public string Path { get; set; }
        public File(string name, string ext, BigInteger size, string path)
        {
            Name = name;
            Extennsion = ext;
            Size = size;
            Path = path;
        }
    }
}
