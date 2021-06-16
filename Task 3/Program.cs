using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чила от 0 до 255. Скалько чисел Вы хотите ввести?");
            int n = Int32.Parse((Console.ReadLine())); // Считываем строку, переводим в число.
            byte[] array = new byte[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите число №{i + 1}");
                array[i] = Byte.Parse(Console.ReadLine()); //Заполняем его
            }

            File.WriteAllBytes("myBytesFile.bin", array);
        }
    }
}
