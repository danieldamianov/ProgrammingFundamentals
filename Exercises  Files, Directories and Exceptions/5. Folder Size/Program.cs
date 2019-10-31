using System;
using System.IO;

namespace _5._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            string[] filesInDir = Directory.GetFiles("TestFolder");
            foreach (var file in filesInDir)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            
            File.WriteAllText("Output.txt",((double)sum / 1024 / 1024).ToString());
        }
    }
}
