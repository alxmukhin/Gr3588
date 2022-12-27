int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] array = FillArrayRandom(rows, columns);
PrintArray(array);
PrintMeans(CalculateMean(array));
PrintArrayDiagonal(array, CalculateMeanDiagonal(array));

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


double CalculateMeanDiagonal(int[,] array)
{
    double diagonalMean = 0;
    double diagonalSum = 0;
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            diagonalSum = diagonalSum + array[i, i];
        }
        diagonalMean = diagonalSum / array.GetLength(0);
    }
    else
    {
        diagonalMean = 0;
    }
    return diagonalMean;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  {0}   ", array[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintArrayDiagonal(int[,] array, double diagonalMean)
{
    if(diagonalMean == 0)
    {
        Console.WriteLine("Матрица не является квадратной, нельзя посчитать среднее арифимитическое элементов на диагонали!");
    }
    else
    {
        Console.WriteLine("Среднее арифметическое элементов матрицы по диагонали равно:" + " {0:N2}",diagonalMean);
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(i==j)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("  {0}   ", array[i, j]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  {0}   ", array[i, j]);
                    Console.ResetColor();

                }
            }
            Console.WriteLine();
        }
    }
}

void PrintMeans(double[] means)
{
    Console.WriteLine("Средние арифметические элементов столбцов равны:");
    for(int i = 0; i < means.Length; i++)
    {
        Console.Write(" {0:N2} ", means[i]);
    }
    Console.WriteLine();
}