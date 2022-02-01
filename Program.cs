//
// Домашнее задание к занятию 8. Работа с файловой системой
//
// Задача 3. Вручную подготовьте текстовый файл с фрагментом текста. 
// Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте. 
//

using System.IO;
string path = "TextFile";
if (!File.Exists(path))
{
    File.Create(path);
}
string line;
int numberL = 0;
int numberW = 0;
int numberS = 0;
using (StreamReader sr = new StreamReader(path))
{
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
        if (line.Length > 0)
        {
            foreach (char x in line)
                if (x == ' ')
                {
                    numberS++;
                }
                else
                {
                    numberW++;
            }
            numberL++;
        }

    }
}

Console.WriteLine();
Console.WriteLine("Статистика:");
Console.WriteLine("Количество символов \t {0}", numberS + numberW);
Console.WriteLine("Количество пробелов \t {0}", numberS);
Console.WriteLine("Количество строк \t {0}",numberL);
Console.WriteLine("Количество слов \t {0}", numberS + 1+numberL);
Console.ReadKey();