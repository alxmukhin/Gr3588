//use ReadData method in order to collect coordinates of two points
int coordX1 = ReadData("Введите координату x1:");
int coordY1 = ReadData("Введите координату y1:");
int coordZ1 = ReadData("Введите координату z1:");
int coordX2 = ReadData("Введите координату x2:");
int coordY2 = ReadData("Введите координату y2:");
int coordZ2 = ReadData("Введите координату z2:");
//use PrintData method in order to output result of calculation received by applying CalculateLength method
PrintData("Расстояние между точками равно: ", CalculateLength(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2));

//ReadData method prints input data request message, its output is integer value inserted by the user
int ReadData(string message)
{
    //output request data message
    Console.WriteLine(message);
    //method return will be integer value received from inserted string by conversion, null safety check also is done here
    return int.Parse(Console.ReadLine() ?? "0");
}

//CalculateLenght method calculates distance between two points in three-dimensional coordinate system, its output is double value
double CalculateLength (int coordX1, int coordX2, int coordY1, int coordY2, int coordZ1, int coordZ2)
{
    //distance is calculated by formula, Math class is used for calqulation of square and square root
    double distance = Math.Sqrt(Math.Pow((coordX1-coordX2),2) + Math.Pow((coordY1-coordY2),2) + Math.Pow((coordZ1-coordZ2),2));
    //method return is calculated double value
    return distance;
}

//PrintData method prints distance value between two points
void PrintData (string message, double distance)
{
    //output of calculation result with description message prior it
    Console.WriteLine(message + distance);
}