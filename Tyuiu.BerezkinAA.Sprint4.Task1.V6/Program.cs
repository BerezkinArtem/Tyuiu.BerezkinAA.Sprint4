using Tyuiu.BerezkinAA.Sprint4.Task1.V6.Lib;


namespace Tyuiu.BerezkinAA.Sprint4.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 7 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива. С клавиатуры: 2, 4, 4, 7, 2, 5, 4, 3, 3, 4    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение четных элементов:  " + ds.Calculate(array));
        }
    }
}
