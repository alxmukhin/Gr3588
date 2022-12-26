int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] array = FillArrayRandom(rows, columns);
PrintArray(array);
int rowNumber = ReadData("Введите номер строки искомого элемента: ");
int columnNumber = ReadData("Введите номер столбца искомого элемента: ");
PrintSearchResult(ElementSearch(array, rowNumber, columnNumber));

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

int ElementSearch(int[,] array, int rowNumber, int columnNumber)
{
    int result = new();
    if(rowNumber > array.GetLength(0) || columnNumber > array.GetLength(1))
    {
        result = 0;
    }
    else
    {
        result = array[rowNumber - 1, columnNumber - 1];
    }
    return result;
}

void PrintArray(int[,] array)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write("{0}  ", array[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

void PrintSearchResult(int result)
{
    if(result == 0)
    {
        Console.WriteLine("В массиве нет элемента с такими параметрами!");
    }
    else
    {
         Console.WriteLine("Значение искомого элемента равно: " + result);
    }
}