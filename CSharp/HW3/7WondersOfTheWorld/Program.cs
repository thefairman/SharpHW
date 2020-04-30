using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7WondersOfTheWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseWonders> baseWonders = new List<BaseWonders>();
            baseWonders.Add(new AlexandriyskiyMayak.Wonder());
            baseWonders.Add(new GalikarnasskiMavzolei.Wonder());
            baseWonders.Add(new HramArtemidi.Wonder());
            baseWonders.Add(new KolosRodovskiy.Wonder());
            baseWonders.Add(new Piramidi.Wonder());
            baseWonders.Add(new SadiMerimiadi.Wonder());
            baseWonders.Add(new StatuyaZevsa.Wonder());

            foreach (var item in baseWonders)
            {
                item.Print();
            }
        }
    }
}
