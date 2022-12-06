int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int coordX1 = ReadData("Введите координату Х1:");
int coordY1 = ReadData("Введите координату Y2:");
int coordX2 = ReadData("Введите координату Х1:");
int coordY2 = ReadData("Введите координату Y2:");

double CalculateLength (int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return distance;
}

void PrintData (string msg, double dist)
{
    Console.WriteLine(msg + dist);
}

PrintData("Расстояние между точками равно: ", CalculateLength(coordX1, coordX2, coordY1, coordY2));