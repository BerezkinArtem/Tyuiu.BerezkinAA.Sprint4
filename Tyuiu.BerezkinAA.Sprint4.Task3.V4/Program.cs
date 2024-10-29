using Tyuiu.BerezkinAA.Sprint4.Task3.V4.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] array = new int[5, 5] { { 6, 5, 4, 1, 5 },
                                           { 8, 2, 3, 4, 2 },
                                           { 3, 7, 7, 1, 3 },
                                           { 3, 4, 8, 1, 3 },
                                           { 4, 3, 5, 5, 2 } };
            Console.Title = "Спринт #4 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в последнем столбце массива.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int h = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 2)
                    {
                        h = array[i, j];
                    }
                }
            }



                        Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Минимальный элемент в последнем столбце: " + h);
        }
    }
}
