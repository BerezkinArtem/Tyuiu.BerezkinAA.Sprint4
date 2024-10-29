using System.Net.Http.Headers;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerezkinAA.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            int h = 0;
        for ( int i = 0; i < array.GetLength(0);  i++ )
            {
                for ( int j = 0; j < array.GetLength(1); j++ )
                {
                    if (array[i, j] == 2)
                    {
                        h = array[i, j];
                        
                    }
                    
                }
            }
            return h;

        }
    }
}
