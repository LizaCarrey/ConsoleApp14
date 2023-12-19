using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Вычислить значение функции для целых аргументов двумя способами
            //(1 - й способ: полный условный оператор; 2 - й способ: тернарная операция):
            //Console.Write("Введите число - ");
            //int x = int.Parse(Console.ReadLine());
            //double y = 0;
            //if (x > 0)
            //{
            //    y = Math.Sin(x) * Math.Sin(x);
            //}
            //else
            //{
            //    y = 1 - 2 * Math.Sin(x * x);
            //}
            //Console.WriteLine($"y={y:f2}");

            //2. Используя двузначное случайное число,
            //вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции

            //Random random = new Random();
            //int number = random.Next(10, 99);
            //Console.WriteLine(number);
            //string str = (number % 2 == 0) ? "четное" : "нечетное";
            //Console.WriteLine(str);

            //3.Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1;
            //если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.

            //Console.Write("Введите первое число - ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число - ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Введите третье число - ");
            //int c = int.Parse(Console.ReadLine());


            //if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            //{
            //    a /= 2;
            //    b /= 2;
            //    c /= 2;
            //}
            //else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            //{
            //    a *= 2;
            //    b *= 2;
            //    c *= 2;
            //}
            //else
            //{
            //    a ++;
            //    b ++;
            //    c ++;
            //}
            //Console.WriteLine($"{a} \t {b} \t {c}");



            //4.По введенному номеру месяца выводится название поры года
            //(зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр

            //Console.Write("Введите номер месяца - ");
            //int month;
            //string season;
            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        season = "зима";
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        season = "весна";
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        season = "лето";
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        season = "осень";
            //        break;
            //    default:
            //        season = "неизвестная пора года";
            //        break;
            //}
            //Console.WriteLine($"Месяц {month} соответствует поре года - {season}");
            //switch (month)
            //{
            //    case 1:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Сейчас каникулы.");
            //        break;
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //    case 6:
            //        Console.WriteLine("Сейчас 2 семестр.");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("Сейчас 1 семестр.");
            //        break;
            //    default:
            //        Console.WriteLine("Введён некорректный месяц.");
            //        break;



            //}
            Console.Read();
        }
    }
}
