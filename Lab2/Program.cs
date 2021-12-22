using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Система система = Система.Новые_задачи();
            Console.WriteLine("Система готова к работе.");
            Console.WriteLine("Ввод данных работника:");
            Console.Write("ФИО: ");
            string фиоР = Console.ReadLine();
            Console.Write("ID: ");
            string ID_R = Console.ReadLine();
            Работник исполнитель = new Работник(фиоР, ID_R);
            int операция = 0;
            do
            {
                Console.Write("\nВыберите действие:\n" +
                    "1 - Список непринятых задач\n" +
                    "2 - Принять задачу на выполнение\n" +
                    "3 - Завершить выполнение задачи\n" +
                    "0 - Выход\n" +
                    "Ваш выбор: ");
                операция = Convert.ToInt32(Console.ReadLine());
                switch (операция)
                {
                    case 1: система.Список_непринятых_задач(); break;
                    case 2:
                        Console.Write("Номер задачи: ");
                        int номер = Convert.ToInt32(Console.ReadLine());
                        система.Принять_задачу_на_выполнение(номер, исполнитель); break;
                    case 3:
                        Console.Write("Номер задачи: ");
                        номер = Convert.ToInt32(Console.ReadLine());
                        система.Завершить_выполнение_задачи(номер, исполнитель); break;
                    default:
                        break;
                }
            } while (операция != 0);
            Console.WriteLine("Работа завершена."); 
            
            Console.ReadLine();
        }
    }
}