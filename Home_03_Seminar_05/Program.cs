/* Задача 3: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
4 3 1 => Строка с индексом 0
2 6 9 
4 6 2 
 */

using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

namespace Home_03_Seminar_05
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] array = TwoArray(10, 2, 1, 9);
            PrintTwoArray(array);
            System.Console.WriteLine();
            int[] oneArray = OneArray(array);
            System.Console.WriteLine("сумма элементов в строках:");
            PrintOneArray(oneArray);
            System.Console.WriteLine();
            int index = MinSummaArray(oneArray);
            System.Console.WriteLine($"строка с наименьшей суммой элементов: {index}");

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

        public static void PrintOneArray(int[] array)
        {
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {

                System.Console.Write(array[i] + "\t");
            }
            System.Console.WriteLine();
        }



        public static int[] OneArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] oneArray = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int j = 0;
                int sum = 0;
                while (j < cols)
                {
                    sum = sum + array[i, j];
                    j++;
                }
                //sum = sum / cols;
                oneArray[i] = sum;
            }

            return oneArray;
        }


        public static int MinSummaArray(int[] oneArray)
        {
            int rows = oneArray.Length;
            int min = oneArray[0];
            int index = 0;
            for (int i = 1; i < rows; i++)
            {
                //int min = summaArray[0];
                if (min > oneArray[i])
                {
                    min = oneArray[i];
                    index = i;
                    //System.Console.WriteLine(min);}
                }
            }
            return index;
        }
    }
}



