using System;

namespace Lab3
{
    public class Task
    {
        private int M, N;
        private int[,] a, b;
        private double average;

        public void InputValues()
        {
            Console.Write("Введите кол-во строк в матрице: ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов в матрице: ");
            N = Convert.ToInt32(Console.ReadLine());

            a = new int[M, N];

            // Генератор элементов матрицы
            Random r = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = r.Next(100);
                }
            }

            b = a;
        }

        public void OutputMatrix()
        {
            Console.WriteLine("\nИсходная матрица: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (a[i, j] > 9)
                        Console.Write(a[i, j] + " ");
                    else
                        Console.Write(" " + a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void AverageOfMatrixElements()
        {
            int K = 0;
            double sum = 0;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum += a[i, j];
                    K++;
                }
            }

            average = sum / K;
            Console.WriteLine(string.Format("\nСреднее арифметическое элементов матрицы: {0:N1}", average));
        }

        public void RezultingMatrix()
        {
            Console.WriteLine("\nРезультирующая матрица\n" +
                "(все элементы больше среднего арифметического матрицы заменены на -1):");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (a[i, j] > average)
                        b[i, j] = -1;
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (b[i, j] > 9 || b[i, j] == -1)
                        Console.Write(a[i, j] + " ");
                    else
                        Console.Write(" " + a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}