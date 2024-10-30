﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerezkinAA.Sprint4.Task5.V4.Lib
{
    public class DataService : ISprint4Task5V4
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cals = matrix.Length / rows;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cals; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
           return count;
        }
    }
}
