﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._2
{
    internal class Empoyee<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }

        //public Empoyee(T num, string name, int summa)
        //{
        //    Num = num;
        //    Name = name;
        //    Summa = summa;
        //}

        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите зп");
            Summa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
