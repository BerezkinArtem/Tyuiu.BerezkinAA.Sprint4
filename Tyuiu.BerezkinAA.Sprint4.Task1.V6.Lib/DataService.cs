using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BerezkinAA.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int r = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    r *= array[i];
                }
            }
            return r;
        }
    }
}
   