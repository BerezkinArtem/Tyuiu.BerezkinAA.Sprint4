using System.Numerics;
using Tyuiu.BerezkinAA.Sprint4.Task5.V4.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Березкин А.А | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значени*");
            Console.WriteLine("* с клавиатуры в диапазоне от 4 до 9. Найдите сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество столбцов:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк:");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            int[,] mtrx = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mtrx[i, j] = rnd.Next(-4, 6);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Количество положительных чисел: " + ds.Calculate(mtrx));
        }
    }
}
