using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ssssss
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fstream = File.OpenRead($"D:\\bb.txt"))
            {

                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);

                Console.WriteLine(Regex.Replace(textFromFile,
                @"(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})",
                "${day}.${month}.${year}"));
            }
        }
    }
}
