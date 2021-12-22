using System;

namespace Lab1
{
    public class MyTask
    {
        public static void DoTask()
        {
            Console.WriteLine("Вычисление куба суммы чисел с чётным номером.");
            Console.Write("Введите кол-во чисел: ");
            int N = Convert.ToInt32(Console.ReadLine());

            double[] a = new double[N]; 
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите число №"+ (i + 1) + ": ");
                a[i] = Convert.ToDouble(Console.ReadLine());

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