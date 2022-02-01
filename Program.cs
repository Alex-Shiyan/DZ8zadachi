//
// Домашнее задание к занятию 8. Работа с файловой системой
//
// Задача 2. Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
// Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.

using System.IO;

// Создаем текстовый файл с именем "TextFile".
string path = "TextFile";
if (! File.Exists(path))
{
    File.Create(path);
}
// Обнуляем содержимое файла, если там остались какие-то значения
using (FileStream fs = File.Create(path))
{

}
// Записываем в файл 10 случайных чисел в интервале от 0 до 10
int[] numberN = new int[10];
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    numberN[i] = random.Next(0,10);
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        sw.WriteLine(numberN[i]);
    }
}
// Считаем сумму чисел
int sumS = 0;
int flagF = 0;
string line;
using (StreamReader sr = new StreamReader(path))
    {
        while ((line = sr.ReadLine()) != null)
        {
            int numberS = Convert.ToInt32(line);
            flagF ++;
            Console.WriteLine("Число {0} равно \t {1}", flagF, numberS);
            sumS = sumS + numberS;

        }

    }
Console.WriteLine();
Console.WriteLine("Сумма чисел равна {0} ", sumS);
Console.ReadKey();
