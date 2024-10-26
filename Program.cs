using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        {
            {   //Task1

                int size = 7;
                int[,] array = new int[size, size];
                Random rand = new Random();

               
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        array[i, j] = rand.Next(0, 100);
                    }
                }

                Console.WriteLine("Початкова матриця:");
                PrintMatrix(array);

                
                int maxIndex = 0;
                int maxValue = Math.Abs(array[0, 0]);
                for (int i = 0; i < size; i++)
                {
                    if (Math.Abs(array[i, i]) >= maxValue)
                    {
                        maxValue = Math.Abs(array[i, i]);
                        maxIndex = i;
                    }
                }

               
                int swapRow = (maxIndex == size - 1) ? 0 : maxIndex + 1;

              
                for (int j = 0; j < size; j++)
                {
                    int temp = array[maxIndex, j];
                    array[maxIndex, j] = array[swapRow, j];
                    array[swapRow, j] = temp;
                }

                Console.WriteLine("\nПеретворена матриця:");
                PrintMatrix(array);
            }

            // Метод для виведення матриці у консоль
             void PrintMatrix(int[,] matrix)
             {
                int size = matrix.GetLength(0);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    }
}
