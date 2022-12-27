int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
//int[,] array = FillArrayRandom(rows, columns);
int[,] array = FillArrayFibonacci(rows, columns);
//PrintArray(array);
int rowNumber = ReadData("Введите номер строки искомого элемента: ");
int columnNumber = ReadData("Введите номер столбца искомого элемента: ");
PrintSearchResult(ElementSearch(array, rowNumber, columnNumber));
PrintArrayFibonacci(array, rowNumber, columnNumber);

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// int[,] FillArrayRandom(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i, j] = new System.Random().Next(1, 10);
//         }
//     }
//     return array;
// }

int[,] FillArrayFibonacci(int rows, int columns)
{
    int number = rows * columns;
    int[] numbersFibonacci = new int[number];
    numbersFibonacci[0] = 0;
    numbersFibonacci[1] = 1;
    for(int k = 2; k < number; k++)
    {
       numbersFibonacci[k] = numbersFibonacci[k-2] + numbersFibonacci[k-1];
    }
    
    int[,] array = new int[rows, columns]; 
    int n = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = numbersFibonacci[n];
            n++;
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

// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0}  ", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

void PrintArrayFibonacci(int[,] array, int rowNumber, int columnNumber)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == rowNumber - 1 && j == columnNumber - 1)
            {  
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}  ", array[i, j]);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("{0}  ", array[i, j]);
                Console.ResetColor();
            }
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