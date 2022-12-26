int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] array = FillArrayRandom(rows, columns);
PrintArray(array);
PrintMeans(CalculateMean(array));

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] FillArrayRandom(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new System.Random().Next(1, 10);
        }
    }
    return array;
}

double[] CalculateMean(int[,] array)
{
    double[] columnSum = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            columnSum[j] = columnSum[j] + array[i, j]; 
        }
    }
    double[] means = new double[array.GetLength(1)];
    for(int k = 0; k < array.GetLength(1); k++)
    {
        means[k] = columnSum[k] / array.GetLength(0);
    }
    return means;
}

void PrintArray(int[,] array)
{
    // ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    //                                     ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    //                                     ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    //                                     ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    //                                     ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    //                                     ConsoleColor.Yellow};
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            //Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write("  {0}   ", array[i, j]);
            //Console.ResetColor();
        }
        Console.WriteLine();
    }
}

void PrintMeans(double[] means)
{
    Console.WriteLine("Средние арифметические элементов столбцов равны:");
    for(int i = 0; i < means.Length; i++)
    {
        Console.Write(" {0:N2} ", means[i]);
    }
}