//Informational message to user explaning linera equation princible
Console.WriteLine("Прямая  описывается уравнением вида y=k*x+b. Задайте значения k и b для двух прямых.");
//Collect "k" and "b" coefficients for three lines
double k1 = ReadData("Введите значение k1: ");
double b1 = ReadData("Введите значение b1: ");
double k2 = ReadData("Введите значение k2: ");
double b2 = ReadData("Введите значение b2: ");
double k3 = ReadData("Введите значение k3: ");
double b3 = ReadData("Введите значение b3: ");
//Show coordinates of three intersection point for lines
PrintResultIntersection(IntersectionCalculation(k1, k2, b1, b2));
PrintResultIntersection(IntersectionCalculation(k1, k3, b1, b3));
PrintResultIntersection(IntersectionCalculation(k2, k3, b2, b3));
//Calculate and record intersection points coordinates
double[] x1y1 = IntersectionCalculation(k1, k2, b1, b2);
double[] x2y2 = IntersectionCalculation(k1, k3, b1, b3);
double[] x3y3 = IntersectionCalculation(k2, k3, b2, b3);
//Calculate square of triangle defined by intersection points and show it
PrintResultTriangleSquare(triangleSquareCalculation(x1y1, x2y2, x3y3));

//ReadData method requests user to input data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Calculation of intersection point for two lines described by two equations
double[] IntersectionCalculation(double k1, double k2, double b1, double b2)
{
    //Create new array of two elements to store x and y coordinates
    double[] xyIntersection = new double[2];
    //Calculation x coordinate of intersection point
    xyIntersection[0] = (b2 - b1)/(k1 - k2);
    //Calculate y coortinate of intersection point
    xyIntersection[1] = k1 * xyIntersection[0] + b1;
    return xyIntersection;
}

//Calculate triangle square based on coordinates of three points
double triangleSquareCalculation(double[] x1y1, double[] x2y2, double[] x3y3)
{
    //Take coordinates from three arrays received from IntersectionCalculation method
    double x1 = x1y1[0];
    double y1 = x1y1[1];
    double x2 = x2y2[0];
    double y2 = x2y2[1];
    double x3 = x3y3[0];
    double y3 = x3y3[1];
    //Calculate triangle square as per formula
    double triangleSquare = Math.Abs((x2-x1)*(y3-y1) - (x3-x1)*(y2-y1)) / 2;
    return triangleSquare;
}

//PrintResultIntersection method used for output calculated intersection coordinates
void PrintResultIntersection(double[] xyIntersection)
{
    Console.WriteLine("Координаты пересечения: x=" + xyIntersection[0] + ", y=" + xyIntersection[1]);
}

//PrintResultTriangleSquare used for output of triangle square
void PrintResultTriangleSquare(double triangleSquare)
{
    Console.WriteLine("Площадь треугольника с координатами вершин соответствующими пересечению прямых равна: " + triangleSquare);
}