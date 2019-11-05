using System;
using System.IO;

namespace Browser
{
    class Program
    {// Testing the getfiles method and getting familiar with how it can be used in my project
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\allen\Desktop");
            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
