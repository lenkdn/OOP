using System;
using System.Collections.Generic;
using System.Linq;
using static Lab2.Задача;

namespace Lab2
{
    public class Система
    {
        private readonly Dictionary<Задача, List<Работник>> список = new Dictionary<Задача, List<Работник>>();

        public Система() { }

        public void Принять_задачу_на_выполнение(int номер_задачи, Работник работник)
        {
            var res = (from ob in список where ob.Key.номер == номер_задачи select ob).ToList();

            if (res.Count != 0)
            {
                if (res[0].Key.статус == Статус.Не_принята)
                {
                    res[0].Key.статус = Статус.Выполняется;
                    res[0].Value.Add(работник);
                    Console.WriteLine("Задача №" + номер_задачи + " (" + res[0].Key.название + ") " + "принята на выполнение.");
                }
                else if (res[0].Key.статус == Статус.Выполняется)
                    Console.WriteLine("Задача №" + номер_задачи + " уже выполняется!");
                else
                    Console.WriteLine("Задача №" + номер_задачи + " уже завершена!");
            }
            else
                Console.WriteLine("Задачи с таким номером не существует!");
        }

        public void Завершить_выполнение_задачи(int номер_задачи, Работник работник)
        {
            var res = (from ob in список where ob.Key.номер == номер_задачи select ob).ToList();

            if (res.Count != 0)
            {
                if (res[0].Key.статус == Статус.Выполняется)
                {
                    res[0].Key.статус = Статус.Завершена;
                    Console.WriteLine("Выполнение задачи №" + номер_задачи + " (" + res[0].Key.название + ") " + "завершено.");
                }
                else if (res[0].Key.статус == Статус.Не_принята)
                    Console.WriteLine("Сначала необходимо принять задачу с данным номером!");
                else
                    Console.WriteLine("Задача №" + номер_задачи + " уже завершена!");
            }
            else
                Console.WriteLine("Задачи с таким номером не существует!");
        }

        public static Система Новые_задачи()
        {
            var res = new Система();
            var новая_задача = new Задача
            {
                номер = 1,
                название = "Разработка мобильного приложения",
                категория = Категория.Программирование,
                крайний_срок_выполнения = new DateTime(2022, 03, 18),
                статус = Статус.Не_принята
            };
            res.список.Add(новая_задача, new List<Работник>());

            новая_задача = new Задача
            {
                номер = 2,
                название = "Создание логотипа компании",
                категория = Категория.Дизайн,
                крайний_срок_выполнения = new DateTime(2021, 11, 19),
                статус = Статус.Не_принята
            };
            res.список.Add(новая_задача, new List<Работник>());

            return res;
        }

        public void Список_непринятых_задач()
        {
            int k = 0;
            foreach (var item in список.Keys)
            {
                if (item.статус == Статус.Не_принята)
                {
                    Console.WriteLine("\n" + item.номер + ") " + item.название + "\n" +
                        "Категория: " + item.категория + "\n" +
                        "Выполнить до: " + item.крайний_срок_выполнения);
                }
                else
                    k++;
            }
            if (k != 0)
                Console.WriteLine("\nНа данный момент новых задач нет.");
        }
    }
}