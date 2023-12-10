/* рамму, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет.
4 3 1 (1,2) => 9
2 6 9 */

using System.Data;
using System.Drawing;

namespace Home_01_Seminar_05
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] array = TwoArray(5, 5, 1, 9);
            PrintTwoArray(array);
            NumberOfArray(array);

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
        public static void NumberOfArray(int[,] array)
        {
            //int number = array[DataRowState, ColorTranslator ];
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            System.Console.WriteLine($"введите номер строки от 0 до {rows - 1}");
            int inum = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine($"введите номер столбца от 0 до {cols - 1}");
            int jnum = Convert.ToInt32(System.Console.ReadLine());
            //int number = array[rows-1,cols-1];
            if (inum > rows || jnum > cols) { System.Console.WriteLine("такого элемента нет"); }
            else
            {
                System.Console.WriteLine($"значение элемента {array[inum, jnum]}");

            }

        }
    }
}



