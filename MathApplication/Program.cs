using System.Linq;
using System.Text.Json;

List<MathApplication.IShape> ShapeObj = new List<MathApplication.IShape>();

MathApplication.IShape CircleData = new MathApplication.Circle(3);
ShapeObj.Add(CircleData);

MathApplication.IShape EquilateralTriangleData = new MathApplication.Triangle(3, 3, 3, 3);
ShapeObj.Add(EquilateralTriangleData);

MathApplication.IShape IsoscelesTriangle1Data = new MathApplication.Triangle(3, 3, 2, 3.5);
ShapeObj.Add(IsoscelesTriangle1Data);

MathApplication.IShape IsoscelesTriangle2Data = new MathApplication.Triangle(3, 2, 3, 3);
ShapeObj.Add(IsoscelesTriangle2Data);

MathApplication.IShape ScaleneTriangleData = new MathApplication.Triangle(3, 2, 1, 3);
ShapeObj.Add(ScaleneTriangleData);

MathApplication.IShape SquareData = new MathApplication.Quadrilateral(3, 3);
ShapeObj.Add(SquareData);

MathApplication.IShape RectangleData = new MathApplication.Quadrilateral(3, 5);
ShapeObj.Add(RectangleData);

//Sort Shape Collection by Area
var sortByArea = ShapeObj.OrderBy(x => x.Area);
Console.WriteLine("Shape Collection sorted by Area :");
foreach (MathApplication.IShape shapeInfo in sortByArea)
{
    Console.WriteLine(JsonSerializer.Serialize(shapeInfo));
}

//Sort Shape Collection by Perimeter
var sortByPerimeter = ShapeObj.OrderBy(x => x.Perimeter);
Console.WriteLine("\n Shape Collection sorted by Perimeter :");
foreach (MathApplication.IShape shapeInfo in sortByPerimeter)
{
    Console.WriteLine(JsonSerializer.Serialize(shapeInfo));
}

//Cicle Obj Count
int circlecount = MathApplication.Circle.CircleObjCount;
Console.WriteLine("\n Total Cicle objects created :" + circlecount);

//Triangle obj count
int Trianglecount = MathApplication.Triangle.TriangleObjCount;
Console.WriteLine("\nTotal Triangle objects created :" + Trianglecount);

//Quadrilateral obj count
int QuadrilateralCount = MathApplication.Quadrilateral.QuadrilateralObjCount;
Console.WriteLine("\nTotal Quadrilateral objects created :" + QuadrilateralCount);

//Save data to Json file
MathApplication.JsonFileCreation FileObj = new MathApplication.JsonFileCreation();
string Result = FileObj.SaveFile(ShapeObj);
Console.WriteLine("\n"+Result);