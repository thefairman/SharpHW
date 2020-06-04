using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7WondersOfTheWorld
{
    class BaseWonders
    {
        virtual public void Print()
        {
            Console.WriteLine(this.GetType().Namespace);
        }
    }
}
