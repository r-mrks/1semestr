using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Laba7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZNAK[] znaks = new ZNAK[2];
            Console.WriteLine("Введите 3 знаков\n");
            for (int i = 0; i < znaks.Length; i++)
            {
                ZNAK znk = new ZNAK();
                Console.Write("Введите имя и фамилию: ");
                znk.NameSurname = Console.ReadLine();
                Console.Write("Введите знак задиак: ");
                string zs = Console.ReadLine();
                switch (zs) // свитч сравнивает значения, и если оно совпадает, то выполняется блок инструкций
                {
                    case "Овен":
                        znk.ZodiacsSign = Zodiacs.Овен;
                        break;
                    case "Телец":
                        znk.ZodiacsSign = Zodiacs.Телец;
                        break;
                    case "Близнецы":
                        znk.ZodiacsSign = Zodiacs.Близнецы;
                        break;
                    case "Рак":
                        znk.ZodiacsSign = Zodiacs.Рак;
                        break;
                    case "Лев":
                        znk.ZodiacsSign = Zodiacs.Лев;
                        break;
                    case "Дева":
                        znk.ZodiacsSign = Zodiacs.Дева;
                        break;
                    case "Весы":
                        znk.ZodiacsSign = Zodiacs.Весы;
                        break;
                    case "Скорпион":
                        znk.ZodiacsSign = Zodiacs.Скорпион;
                        break;
                    case "Стрелец":
                        znk.ZodiacsSign = Zodiacs.Стрелец;
                        break;
                    case "Козерог":
                        znk.ZodiacsSign = Zodiacs.Козерог;
                        break;
                    case "Водолей":
                        znk.ZodiacsSign = Zodiacs.Водолей;
                        break;
                    case "Рыба":
                        znk.ZodiacsSign = Zodiacs.Рыба;
                        break;
                    default:
                        Console.Write("Нет такого знака задиака ");
                        break;
                }

                znk.DateOfBirth = new int[3];
                Console.Write("Введите год : ");
                znk.DateOfBirth[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц : ");
                znk.DateOfBirth[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите день: ");
                znk.DateOfBirth[2] = Convert.ToInt32(Console.ReadLine());
                znaks[i] = znk;
            }
            Array.Sort(znaks, (curentZnak, nextZnak) => curentZnak.CompareTo(nextZnak));
            string text1 = "";
            foreach (var znak in znaks)
            {
                text1 += znak + "\n";
            }

            File.WriteAllText("C:\\Users\\lab7.txt", text1);
            Console.WriteLine("Вывод из файла");
            foreach (string s in File.ReadLines("C:\\Users\\lab7.txt"))
            {
                Console.WriteLine(s);
            }
            Console.Write("Введите знак который хотите: ");
            string zodSign = Console.ReadLine();
            bool found = false;
            foreach (ZNAK zk in znaks)
            {
                if (zk.ZodiacsSign.ToString().Equals(zodSign))
                {
                    found = true;
                    Console.WriteLine(zk.NameSurname + ", " + zk.DateOfBirth[2] + "-" + zk.DateOfBirth[1] + "-" + zk.DateOfBirth[0]);
                }
            }

            if (!found)
            {

                Console.WriteLine("НЕ найдено");
            }
        }

        public enum Zodiacs
        {
            Овен,
            Телец,
            Близнецы,
            Рак,
            Лев,
            Дева,
            Весы,
            Скорпион,
            Стрелец,
            Козерог,
            Водолей,
            Рыба
        }
        public struct ZNAK : IComparable
        {
            public string NameSurname;
            public Zodiacs ZodiacsSign;
            public int[] DateOfBirth; // 0 - year, 1 - mount, 2 - day

            public int CompareTo(object obj)
            {
                ZNAK com = (ZNAK)obj;
                DateTime dt1 = new DateTime(this.DateOfBirth[0], this.DateOfBirth[1], this.DateOfBirth[2]);
                DateTime dt2 = new DateTime(com.DateOfBirth[0], com.DateOfBirth[1], com.DateOfBirth[2]);
                return dt1.CompareTo(dt2);
            }

            public override string ToString()
            {
                return $"NameSurname: {NameSurname}, ZodiacsSign: {ZodiacsSign}, DateOfBirth: {DateOfBirth[0]}-{DateOfBirth[1]}-{DateOfBirth[2]}";
            }
        }
    }
}