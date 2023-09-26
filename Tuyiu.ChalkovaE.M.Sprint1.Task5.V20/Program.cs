using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tuyiu.ChalkovaE.M.Sprint1.Task5.V1.Lib;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1| Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая расстояние между двумя точками              *");
            Console.WriteLine("* с заданными координатами (x, y).                                        *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            double y1;
            double x2;
            double y2;

            Console.WriteLine("Введите значение х1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение х2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine("Pасстояние между двумя точками = " + res);

            Console.ReadLine();
        }
    }
}
