using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    interface ISimpleNSquare
    {
        double Height { get; set; }
        double Base { get; set; }
        double Angle { get; }
        int SidesCount { get; }
        List<double> SidesLength { get; }
        double Area { get; }
        double Perimeter { get; }
    }
}
