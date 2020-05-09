using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    struct Data
    {
        public int A;
        public int B;
        public int C;
    }

    struct SolvingData
    {
        public double X;
        public double Y;
    }

    struct LinearEquation
    {
        public Data Data { get; private set; }
        public bool TryParse(string str)
        {
            string[] lex = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (lex.Length != 3)
            {
                Console.WriteLine("Колличество ввденных значений != 3");
                return false;
            }
            if (!Int32.TryParse(lex[0], out int a))
            {
                Console.WriteLine("Первый коэфициент должен быть целым числом");
                return false;
            }
            if (!Int32.TryParse(lex[1], out int b))
            {
                Console.WriteLine("Второй коэфициент должен быть целым числом");
                return false;
            }
            if (!Int32.TryParse(lex[2], out int c))
            {
                Console.WriteLine("Свободный член должен быть целым числом");
                return false;
            }
            Data tmpData;
            tmpData.A = a;
            tmpData.B = b;
            tmpData.C = c;
            Data = tmpData;
            return true;
        }

        bool CheckFirstRankNotZero(double[,] matrix)
        {
            for (int i = 0; i < 2; i++)
            {
                bool notOk = true;
                for (int j = 0; j < 2; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        notOk = false;
                        break;
                    }
                }
                if (notOk)
                    return false;
            }
            return true;
        }

        public SolvingData SolvingEquation(LinearEquation le)
        {
            if (Data.A == 0 && le.Data.A == 0)
                throw new Exception("Ни в одном из уравнений нет X");
            double[,] matrix = { { Data.A, Data.B, -Data.C }, { le.Data.A, le.Data.B, -le.Data.C } };
            if (!CheckFirstRankNotZero(matrix))
                throw new Exception("Данная система не имеет решения");
            bool swapped = false;
            if (matrix[0, 0] == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    matrix[0, i] = matrix[1, i];
                }
                matrix[1, 0] = Data.A;
                matrix[1, 1] = Data.B;
                matrix[1, 2] = Data.C;
                swapped = true;
            }

            double multiplier = matrix[1, 0] / matrix[0, 0];
            for (int i = 0; i < 3; i++)
            {
                matrix[1, i] += matrix[0, i] * -multiplier;
            }

            if (!CheckFirstRankNotZero(matrix))
                throw new Exception("Данная система не имеет решения или только одного члена");

            SolvingData solvingData;
            solvingData.Y = matrix[1, 2] / matrix[1, 1];
            solvingData.X = (matrix[0, 2] - solvingData.Y * matrix[0, 1]) / matrix[0, 0];
            if (swapped)
                return new SolvingData { X = solvingData.Y, Y = solvingData.X };
            return solvingData;
        }
    }

}
