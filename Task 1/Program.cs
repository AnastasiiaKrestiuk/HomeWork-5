using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            File.WriteAllText("myFile.txt", Console.ReadLine());
        }
    }
}
