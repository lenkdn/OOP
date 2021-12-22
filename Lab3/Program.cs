using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task();
            t.InputValues();
            t.OutputMatrix();
            t.AverageOfMatrixElements();
            t.RezultingMatrix();

            Console.ReadLine();
        }
    }
}