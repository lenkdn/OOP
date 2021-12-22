using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Решение № 1. Использование статистического метода DoTask().
            // MyTask.DoTask();

            // Решение № 2. Использование методов уровня экземпляра.
            MyTask2Edit ob = new MyTask2Edit();
            ob.InputArray();
            ob.PrintResult();
        }
    }
}