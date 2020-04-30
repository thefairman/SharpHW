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
    }

    struct LinearEquation
    {
        Data Data;
        public bool TryParse(string str)
        {
            string[] lex = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (lex.Length != 2)
            {
                Console.WriteLine("Колличество коэфицентов != 2");
                return false;
            }
            if (Int32.TryParse(lex[0], out int a))
            {
                Console.WriteLine("Первый коэфициент должен быть целым числом");
                return false;
            }
            if (Int32.TryParse(lex[1], out int b))
            {
                Console.WriteLine("Второй коэфициент должен быть целым числом");
                return false;
            }
            Data.A = a;
            Data.B = b;
            return true;
        }
    }

}
