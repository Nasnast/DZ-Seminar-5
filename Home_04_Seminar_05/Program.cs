/* Задача 4*(не обязательная): Задайте двумерный массив 
из целых чисел. Напишите программу, которая удалит 
строку и столбец, на пересечении которых расположен 
наименьший элемент массива. Под удалением 
понимается создание нового двумерного массива без 
строки и столбца
4 3 1 => 2 6
2 6 9    4 6
4 6 2
 */

using System.Data;
using System.Formats.Asn1;
using System.Linq.Expressions;

namespace Home_04_Seminar_05
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] array = TwoArray(3, 3, 1, 9);
            PrintTwoArray(array);
            System.Console.WriteLine();
            int[,] newArray = MinDeletArray(array);
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

        public static int[,] MinDeletArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int min = array[0, 0];
            int iMin = 0;
            int jMin = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        iMin = i;
                        jMin = j;
                    }
                }
            }
           
            System.Console.WriteLine($"значение минимального элемента => {min}, строка {iMin}, столбец {jMin}");

            int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

            for (int i = 0, inew = 0; i < array.GetLength(0); i++)
            {
                if (i == iMin)
                    continue;
                for (int j = 0, jnew = 0; j < array.GetLength(1); j++)
                {
                    if (j == jMin)
                        continue;
                    newArray[inew, jnew] = array[i, j];

                    jnew++;
                }

                inew++;
            }
            return (newArray);
        }
    }

}














