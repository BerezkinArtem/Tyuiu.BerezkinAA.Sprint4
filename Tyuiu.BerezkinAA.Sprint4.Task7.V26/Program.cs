using Tyuiu.BerezkinAA.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string value = "351268459614723";
            DataService ds = new DataService();
            int index = 0;

            Console.Title = "Спринт #4 | Выполнил: Березкин А.А | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 351268459614723.Преобразуйте ее       *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);
            Console.WriteLine("Произведение четных элементов: " + res);
            Console.ReadKey();

        }
    }
}
