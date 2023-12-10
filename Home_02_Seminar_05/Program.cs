/* Задача 2: Задайте двумерный массив. Напишите 
программу, которая поменяет местами первую и 
последнюю строку массива.
4 3 1 =>  4 6 2 
2 6 9     2 6 9
4 6 2     4 3 1 */

using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Home_02_Seminar_05
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] array = TwoArray(5, 5, 1, 9);
            PrintTwoArray(array);
            int[,] newArray = ChangeInArray(array);
            System.Console.WriteLine("новый массив");
            PrintTwoArray(newArray);


        }

        public static int[,] TwoArray(int rows, int cols, int min, int max)
        {
            int[,] array = new int[rows, cols];
            Random rand = new();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(min, max + 1);
                }
            }
            return array;
        }

        public static void PrintTwoArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(array[i, j] + "\t");
                }
                System.Console.WriteLine();
            }

        }
        public static int[,] ChangeInArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int i = 0;
            int j = 0;
            while (j < cols)
            {
                int temp = array[i, j];
                array[i, j] = array[rows - 1, j];
                array[rows - 1, j] = temp;
                j++;
            }
            return array;
        }
    }
}




