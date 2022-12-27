int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
PrintArray(FillArrayRandom(rows, columns));

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] FillArrayRandom(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new System.Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Массив с заданными параметрами:");
    ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new System.Random().Next(0, 16)];
            Console.Write("{0:N2}  ", array[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}