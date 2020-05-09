using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class UI
    {
        static string PrintMiddleElem(int a)
        {
            return a < 0 ? $"- {-a}" : $"+ {a}";
        }
        static void PrintEquation(LinearEquation linearEquation)
        {
            Console.WriteLine($"{linearEquation.Data.A}x {PrintMiddleElem(linearEquation.Data.B)}y {PrintMiddleElem(linearEquation.Data.C)} = 0");
        }
        static public bool AskAgain(bool contine = true)
        {
            Console.WriteLine($"Чтобы {(contine ? "продолжить" : "выполнить еще раз")}, нажмите пробел");
            return Console.ReadKey().Key == ConsoleKey.Spacebar;
        }

        static LinearEquation SetLinearEquation()
        {
            LinearEquation linearEquation = new LinearEquation();
            string str;
            do
            {
                Console.WriteLine("Введите данные линейного уравнения Ax + By + C = 0, ABC вводится через пробел или запятую");
                str = Console.ReadLine();
            } while (!linearEquation.TryParse(str));
            return linearEquation;
        }

        static public void SolvingEquation()
        {
            Console.Clear();
            Console.WriteLine("Введите первое уравнение:");
            LinearEquation linearEquation1 = SetLinearEquation();
            Console.WriteLine("Введите второе уравнение:");
            LinearEquation linearEquation2 = SetLinearEquation();
            Console.Clear();
            Console.WriteLine("Ваши уравнения:");
            PrintEquation(linearEquation1);
            PrintEquation(linearEquation2);
            SolvingData sd;
            try
            {
                sd = linearEquation1.SolvingEquation(linearEquation2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка вычисления: {ex.Message}");
                return;
            }
            Console.WriteLine($"Решение системы уравнений: Х = {sd.X:0.####}; Y = {sd.Y:0.####}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                UI.SolvingEquation();
            } while (UI.AskAgain(false));

            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);

            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;

            Console.WriteLine(f3);
        }
    }
}
