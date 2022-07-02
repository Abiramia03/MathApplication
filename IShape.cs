using System;

namespace MathApplication
{
    public Interface IShape
    {
        public string Name { get; set; }
        public double Area();
        public double Perimeter();
    }
}

