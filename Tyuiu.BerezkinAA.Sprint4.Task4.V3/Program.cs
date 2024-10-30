using Tyuiu.BerezkinAA.Sprint4.Task4.V3.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix = new int[5, 5] {{ 7, 9, 7, 8, 6 },
                                           { 4, 4, 4, 8, 6 },
                                           { 7, 9, 6, 7, 6 },
                                           { 7, 5, 4, 9, 8 },
                                           { 9, 6, 4, 9, 8 } };

            Console.Title = "Спринт #4 | Выполнил: Березкин А.А | ИСПб-24-1";
            DataService ds = new DataService();
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
            int[,] x = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Введите элемент " + i + j + " : ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{x[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));
        }
    }
}
