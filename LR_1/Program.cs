using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"ЛАБОРАТОРНАЯ РАБОТА 1. РАЗРАБОТКА КОНСОЛЬНОГО ПРИЛОЖЕНИЯ");
            Console.WriteLine("Гераськин Артём Андреевич");
            Console.WriteLine("ИДБ-23-01, Направление: 09.03.01");
            Console.WriteLine("13.04.2005");
            Console.WriteLine("г. Москва");
            Console.WriteLine("Алгебра/Химия/Программирование");
            Console.WriteLine("Нравится программировать и изучать что-то новое\n");
            Console.WriteLine("Задание 2.");
            float a = 1, b = 2, t = 3, x = 4, f = 5, i_2 = 6, R_x = a * b + b / t - x + f * i_2;
            Console.WriteLine("a = {0}\nb = {1}\nt = {2}\nx = {3}\nf = {4}\ni_2 = {5}\n", a, b, t, x, f, i_2);
            Console.WriteLine("R_x = {0}", R_x);
        }
    }
}
