using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            File.WriteAllText("myFile.txt", DateTime.Now.ToString());
        }
    }
}
