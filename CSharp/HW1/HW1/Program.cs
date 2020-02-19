using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Logic
    {
        static public int GetSquaresInRectangle(int a, int b, int c, out int rest)
        {
            rest = 0;
            if (c == 0)
                return 0;
            int horiz = a / c;
            int squares = horiz * (b / c);
            rest = a * b - c * c * squares;
            return squares;
        }

        static public double CountDeposite(double percents, out int month)
        {
            double multiplayer = 1.0 + percents / 100;
            double startVal = 10000;
            for (month = 0; startVal < 11000; ++month)
            {
                startVal *= multiplayer;
            }
            return startVal;
        }
    }
    class UI
    {
        static readonly string incorrectValue = "Вы ввели не корректное значение!";
        static bool GetPositiveInteger(out int num, string title)
        {
            Console.WriteLine(String.IsNullOrEmpty(title) ? "Введите целое положительное число:" : title);
            if (!Int32.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine(incorrectValue);
                return false;
            }
            return true;
        }

        static bool GetPositiveDouble(out double num, string title)
        {
            Console.WriteLine(String.IsNullOrEmpty(title) ? "Введите вещественное положительное число:" : title);
            string enteredVal = Console.ReadLine();
            if (Char.IsSeparator('.'))
                enteredVal = enteredVal.Replace(',', '.');
            else
                enteredVal = enteredVal.Replace('.', ',');
            if (!Double.TryParse(enteredVal, out num) || num <= 0)
            {
                Console.WriteLine(incorrectValue);
                return false;
            }
            return true;
        }

        static public void GetSidesAndSquare()
        {
            Console.Clear();
            Console.WriteLine("Расчет количества квадратов С в прямоугальнике AB");
            int a, b, c;
            while (!GetPositiveInteger(out a, "Введите сторону A:")) ;
            while (!GetPositiveInteger(out b, "Введите сторону B:")) ;
            while (!GetPositiveInteger(out c, "Введите сторону квадрата C:")) ;
            int count = Logic.GetSquaresInRectangle(a, b, c, out int rest);
            Console.Write($"В вашем прямоугольние {count} квадрат / ов / а");
            if (count == 0)
                Console.Write(", видать одна из сторон прямоугольника оказалась меньше квадрата");
            else
                Console.Write($"\r\nСвободная площадь: {rest}");
            Console.WriteLine("!");
        }

        static public bool AskAgain()
        {
            Console.WriteLine("Чтобы выполнить еще раз, нажмите пробел");
            return Console.ReadKey().Key == ConsoleKey.Spacebar;
        }

        static public void WhenWillBeMoreThen11000()
        {
            Console.Clear();
            Console.WriteLine("Подсчиать когда вклад в 10 000 будет больше 11 000 гривен");
            double percents;
            while (!GetPositiveDouble(out percents, "Введите размер процента в месяц (0 < P < 25):") || percents >= 25) ;
            double resVal = Logic.CountDeposite(percents, out int month);
            Console.WriteLine($"Спустя {month} м. у вас будет {resVal} грн.");
        }

        static public void ShowNumbers()
        {
            Console.Clear();
            Console.WriteLine("Вывести числа по n раз самого числа");
            int a = 0, b = 0;
            while (a >= b)
            {
                while (!GetPositiveInteger(out a, "Введите целое число > 0 A:")) ;
                while (!GetPositiveInteger(out b, "Введите целое число > 0 B (должно быть меньше числа A):")) ;
                if (a >= b)
                    Console.WriteLine("Число А должно быть меньше В!");
            }
            for (; a <= b; a++)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write($"{a} ");
                }
                Console.Write("\r\n");
            }
        }

        static public void ReverseNum()
        {
            Console.Clear();
            Console.WriteLine("Вывести целое число наоборот");
            int num;
            while (!GetPositiveInteger(out num, "Введите целое число > 0:")) ;
            while (num > 0)
            {
                Console.Write(num % 10);
                num /= 10;
            }
            Console.Write("\r\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                UI.GetSidesAndSquare();
            } while (UI.AskAgain());

            do
            {
                UI.WhenWillBeMoreThen11000();
            } while (UI.AskAgain());

            do
            {
                UI.ShowNumbers();
            } while (UI.AskAgain());

            do
            {
                UI.ReverseNum();
            } while (UI.AskAgain());
        }
    }
}
