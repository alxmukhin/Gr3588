int coordX1 = ReadData("Введите координату x1:");
int coordY1 = ReadData("Введите координату y1:");
int coordZ1 = ReadData("Введите координату z1:");
int coordX2 = ReadData("Введите координату x2:");
int coordY2 = ReadData("Введите координату y2:");
int coordZ2 = ReadData("Введите координату z2:");
PrintData("Расстояние между точками равно: ", CalculateLength(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2));

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

double CalculateLength (int coordX1, int coordX2, int coordY1, int coordY2, int coordZ1, int coordZ2)
{
    double distance = Math.Sqrt(Math.Pow((coordX1-coordX2),2) + Math.Pow((coordY1-coordY2),2) + Math.Pow((coordZ1-coordZ2),2));
    return distance;
}

void PrintData (string message, double distance)
{
    Console.WriteLine(message + distance);
}