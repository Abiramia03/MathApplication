using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    public interface IShape
    {
        string Name { get; set; }
        double Area { get; set; }
        double Perimeter { get; set; }
    }
}
