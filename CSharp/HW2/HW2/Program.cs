using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class UI
    {
        static readonly string incorrectValue = "Вы ввели не корректное значение!";
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        static void PrintArray(int[,] arr)
        {
            int i = 0;
            int lenght = arr.GetLength(1);
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
                if (i++ != 0 && i% lenght == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static public bool AskAgain(bool contine = true)
        {
            Console.WriteLine($"Чтобы {(contine ? "продолжить" : "выполнить еще раз")}, нажмите пробел");
            return Console.ReadKey().Key == ConsoleKey.Spacebar;
        }

        static bool GetInteger(out int num, string title, bool onlyPositive = false)
        {
            Console.WriteLine(String.IsNullOrEmpty(title) ? "Введите число:" : title);
            if (!Int32.TryParse(Console.ReadLine(), out num) || (onlyPositive && num <= 0))
            {
                Console.WriteLine(incorrectValue);
                return false;
            }
            return true;
        }

        static public void ZipArch()
        {
            Console.Clear();
            int[] arr = { 0, 5, 3, 6, 0, 4, 0, 0, 1, 0, 8, 6, 0, 9, 0 };
            Console.WriteLine("изначальный массив:");
            PrintArray(arr);
            Console.WriteLine("Сжатый массив:");
            Logic.ZipArr(arr);
            PrintArray(arr);
        }

        static public void Ranking()
        {
            Console.Clear();
            int[] arr = { -1, 5, -3, 6, 0, 4, 0, 0, -1, 0, 8, 6, 0, -9, -1 };
            Console.WriteLine("изначальный массив:");
            PrintArray(arr);
            Console.WriteLine("Сначала отрицательные, после положительные:");
            Logic.ArrRanking(arr);
            PrintArray(arr);
        }

        static public void CountNumInArr()
        {
            Console.Clear();
            int[] arr = { -1, 5, -3, 6, 0, 4, 0, 0, -1, 0, 8, 6, 0, -9, -1 };
            Console.WriteLine("изначальный массив:");
            PrintArray(arr);
            int a;
            while (!GetInteger(out a, "Введите искомое число:", false)) ;
            int res = 0;
            foreach (var item in arr)
            {
                if (item == a) res++;
            }
            Console.WriteLine($"Ваше число в массиве встречается {res} раз /а");
        }

        static public void SwapColumns()
        {
            Console.Clear();
            int[,] arr = { { -1, 5, -3, 6, 0, 4, 0, 0, -1, 0, 8, 6, 0, -9, },
                                { 0, 5, 3, 6, 0, 4, 0, 0, 1, 0, 8, 6, 0, 9 },
                                { 3, 2, 0, 1, 3, 5, 7, 8, 9, 5, 1, 0, 3, 4 }};
            Console.WriteLine("изначальный массив:");
            PrintArray(arr);
            int a = 0, b = 0;
            while (true)
            {
                while (!GetInteger(out a, "Введите первую колонку > 0:", true)) ;
                while (!GetInteger(out b, "Введите вторую колонку > 0 && != первой колонке:", true)) ;
                try
                {
                    Logic.SwapColumns(arr, --a, --b);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("массив с поменяными колонками:");
            PrintArray(arr);
        }
    }

    class Logic
    {
        static public void SwapColumns(int[,] arr, int a, int b)
        {
            int lenght = arr.GetLength(1);
            if (a == b)
                throw new Exception("вторая колокнка не должна равняться второй колонке!");
            if (a < 0 || b < 0 || a >= lenght || b >= lenght)
                throw new Exception("вышли за диапазон колонок!");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                int tmp = arr[i, a];
                arr[i, a] = arr[i, b];
                arr[i, b] = tmp;
            }
        }
        static public void ZipArr(int[] arr)
        {
            bool onlyZeroes = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (onlyZeroes)
                {
                    arr[i] = -1;
                    continue;
                }
                if (arr[i] == 0)
                {
                    if (i == arr.Length - 1)
                    {
                        arr[i] = -1;
                        break;
                    }
                    int nextI = 0;
                    for (int next = i + 1; next < arr.Length; next++)
                    {
                        if (arr[next] != 0)
                        {
                            nextI = next;
                            break;
                        }
                    }
                    if (nextI == 0)
                    {
                        arr[i] = -1;
                        onlyZeroes = true;
                        continue;
                    }
                    arr[i] = arr[nextI];
                    arr[nextI] = 0;
                }
            }
        }

        static public void ArrRanking(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    int nextMinus = 0;
                    for (int nextM = i + 1; nextM < arr.Length; nextM++)
                    {
                        if (arr[nextM] < 0)
                        {
                            nextMinus = nextM;
                            break;
                        }
                    }
                    if (nextMinus == 0)
                        break;
                    int tmpx = arr[nextMinus];
                    for (int swp = nextMinus; swp > i; swp--)
                    {
                        arr[swp] = arr[swp - 1];
                    }
                    arr[i] = tmpx;
                }
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            UI.ZipArch();
            while (!UI.AskAgain()) ;

            UI.Ranking();
            while (!UI.AskAgain()) ;

            do
            {
                UI.CountNumInArr();
            } while (UI.AskAgain(false));

            do
            {
                UI.SwapColumns();
            } while (UI.AskAgain(false));
        }
    }
}
