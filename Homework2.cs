using System;
using System.Collections.Generic;
using System.Text;

namespace ACC
{
    internal class Homework2
    {


        /*static void MaxMin(int n)
        {
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(10);
               
            }

            
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine($"Max value is {max}/n Min value is {min}");

        }
        static void Main()
        {
            MaxMin(6);
        }*/

        /*----------------------------------------------------------------------------------------------*/

        /*static void Index()
        {
            Random rnd = new Random();
            int[] start_arr = new int[10];
            Console.WriteLine("The Start Array");
            for (int i = 0; i < 10; i++)
            {
                start_arr[i] = rnd.Next(6);
                Console.WriteLine(start_arr[i]);
            }
            int max = start_arr.Max();

            int[] arr = new int[max + 1];

            for (int i = 0; i < start_arr.Length; i++)
            {
                arr[start_arr[i]]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Number {i}-->{arr[i]} Times");
            }
            
        }
        static void Main()
        {
            Index();
        }*/

        /*----------------------------------------------------------------------------------------------*/


        /*static void Diagonals(int n)
        {
            Random rnd = new Random();

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                   
                }

            }

            double firstDiagonal = 0;
            double secondDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        firstDiagonal += matrix[i, j];
                    }

                    if (i + j == n + 1)
                    {
                        secondDiagonal += matrix[i, j];                        
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            double result = firstDiagonal / secondDiagonal;
            Console.WriteLine($"The division of First Diagonal by Second is  {result}");
        }

        static void Main()
        {
            Diagonals(6);
        }/*


        /*----------------------------------------------------------------------------------------------*/

        /*static void SecondDiagonal(int n)
        {
            Random rnd = new Random();

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j > n - 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"The sum of nunbers that are under the Second Diagonal is {sum}");
        }

        static void Main()
        {
            SecondDiagonal(4);
        }*/

        /*----------------------------------------------------------------------------------------------*/

        /*static void Neighbors(int a, int b, int m, int n)
        {
            Random rnd = new Random();

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    int nj = a + j;
                    int ni = b + i;

                    if (ni > 0 && ni < n && nj > 0 && nj < n)
                    {
                        sum += matrix[ni, nj];
                    }
                }
            }

            Console.WriteLine($"Sum is {sum}");
        }

        static void Main()
        {
            Neighbors(2,2 ,4 ,3);
        }*/
    }
}
