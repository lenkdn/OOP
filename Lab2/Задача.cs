using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Задача
    {
        public enum Категория
        {
            Программирование,
            Экономика,
            Дизайн
        };
        public enum Статус
        {
            Не_принята,
            Выполняется,
            Завершена
        };
        public int номер { get; set; }
        public string название { get; set; }
        public Категория категория { get; set; }
        public DateTime крайний_срок_выполнения { get; set; }
        public string примечание { get; set; }
        public Статус статус { get; set; }
    }
}