using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    public class Circle : IShape
    {
        public static int CircleObjCount = 0;
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
            CircleObjCount++;
        }

        //private string _name { get; set; }
        //private double _area { get; set; }
        //private double _perimeter { get; set; }
        public string Name
        {
            get
            
            {
                //_name = AppConstants.Circle;
                //return _name;

                return AppConstants.Circle;
            }
            set
            { }
        }

        public double Area
        {
            get
            {
                //return _area = AppConstants.Pi * Radius * Radius;
                return AppConstants.Pi * Radius * Radius;
            }
            set { }
        }

        public double Perimeter
        {
            get
            {
                //return _perimeter = AppConstants.Pi * AppConstants.Two * Radius;
                return AppConstants.Pi * AppConstants.Two * Radius;
            }
            set { }
        }
    }

    public class Triangle : IShape
    {
        public static int TriangleObjCount = 0;
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }

        public Triangle(double sideA, double sideB, double sideC, double height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = height;
            TriangleObjCount++;
        }

        //private string _name { get; set; }
        //private double _area { get; set; }
        //private double _perimeter { get; set; }
        public string Name
        {
            get
            {
                if (SideA == SideB && SideB == SideC)
                {
                    //_name = AppConstants.Equilateral;
                    return AppConstants.Equilateral;
                }
                else if ((SideA == SideB && SideB != SideC) || (SideA == SideC && SideA != SideB) || (SideB == SideC && SideB != SideA))
                {
                    //_name = AppConstants.Isosceles;
                    return AppConstants.Isosceles;
                }
                else if (SideA != SideB && SideA != SideC && SideB != SideC)
                {
                    //_name = AppConstants.Scalene;
                    return AppConstants.Scalene;
                }

                return AppConstants.Triangle;
            }
            set
            { }
        }

        public double Area
        {
            get
            {
                //return _area = (Height * SideC) / AppConstants.Two;
                return (Height * SideC) / AppConstants.Two;
            }
            set { }
        }

        public double Perimeter
        {
            get
            {
                return  SideA + SideB + SideC;
                //return _perimeter = SideA + SideB + SideC;
            }
            set { }
        }
    }

    public class Quadrilateral : IShape
    {
        public static int QuadrilateralObjCount = 0;
        public double Width { get; set; }
        public double Length { get; set; }

        public Quadrilateral(double width, double length)
        {
            Width = width;
            Length = length;
            QuadrilateralObjCount++;
        }

        public string Name
        {
            get
            {
                if (Width == Length)
                {
                    return AppConstants.Square;
                }
                else
                {
                    return AppConstants.Rectangle;
                }
                return AppConstants.Quadrilateral;
            }
            set
            { }
        }

        public double Area
        {
            get
            {
                return Width * Length;
            }
            set { }
        }

        public double Perimeter
        {
            get
            {
                return (Width + Length) * AppConstants.Two;
            }
            set { }
        }
    }
}
