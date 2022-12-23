Console.WriteLine("Прямая  описывается уравнением вида y=k*x+b. Задайте значения k и b для двух прямых.");
double k1 = ReadData("Введите значение k1: ");
double b1 = ReadData("Введите значение b1: ");
double k2 = ReadData("Введите значение k2: ");
double b2 = ReadData("Введите значение b2: ");
double k3 = ReadData("Введите значение k3: ");
double b3 = ReadData("Введите значение b3: ");
PrintResultIntersection(IntersectionCalculation(k1, k2, b1, b2));
PrintResultIntersection(IntersectionCalculation(k1, k3, b1, b3));
PrintResultIntersection(IntersectionCalculation(k2, k3, b2, b3));
double[] x1y1 = IntersectionCalculation(k1, k2, b1, b2);
double[] x2y2 = IntersectionCalculation(k1, k3, b1, b3);
double[] x3y3 = IntersectionCalculation(k2, k3, b2, b3);
PrintResultTriangleSquare(triangleSquareCalculation(x1y1, x2y2, x3y3));

//ReadData method requests user to input data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[] IntersectionCalculation (double k1, double k2, double b1, double b2)
{
    double[] xyIntersection = new double[2];
    xyIntersection[0] = (b2 - b1)/(k1 - k2);
    xyIntersection[1] = k1 * xyIntersection[0] + b1;
    return xyIntersection;
}

double triangleSquareCalculation(double[] x1y1, double[] x2y2, double[] x3y3)
{
    double x1 = x1y1[0];
    double y1 = x1y1[1];
    double x2 = x2y2[0];
    double y2 = x2y2[1];
    double x3 = x3y3[0];
    double y3 = x3y3[1];
    double triangleSquare = Math.Abs((x2-x1)*(y3-y1) - (x3-x1)*(y2-y1)) / 2;
    return triangleSquare;
}

void PrintResultIntersection(double[] xyIntersection)
{
    Console.WriteLine("Координаты пересечения: x=" + xyIntersection[0] + ", y=" + xyIntersection[1]);
}

void PrintResultTriangleSquare(double triangleSquare)
{
    Console.WriteLine("Площадь треугольника с координатами вершин соответствующими пересечению прямых равна: " + triangleSquare);
}