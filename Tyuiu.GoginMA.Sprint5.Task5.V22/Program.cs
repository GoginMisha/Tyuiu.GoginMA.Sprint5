using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoginMA.Sprint5.Task5.V22.Lib;

namespace Tyuiu.GoginMA.Sprint5.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #22                                                            *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл, в котором есть набор значений. Найти минимальное целое число *");
            Console.WriteLine("* в файле, которое делится на 4.                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное целое число, которое делится на 4 = " + res);
            Console.ReadKey();
        }
    }
}
