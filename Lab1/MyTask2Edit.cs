using System;

namespace Lab1
{
    public class MyTask2Edit
    {
        private int N;
        private double[] a;

        public void InputArray()
        {
            Console.WriteLine("Вычисление куба суммы чисел с чётным номером.");
            Console.Write("Введите кол-во чисел: ");
            N = Convert.ToInt32(Console.ReadLine());

            a = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите число №" + (i + 1) + ": ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void PrintResult()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 != 0)
                    sum += a[i];
            }
            if (N == 1)
                Console.WriteLine("Необходимо ввести больше 1 числа.");
            else
                Console.Write("Ответ: " + Math.Pow(sum, 3));

            Console.ReadLine();
        }
    }
}