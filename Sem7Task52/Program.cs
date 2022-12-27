//get number of rows
int rows = ReadData("Введите число строк: ");
//get number of columns
int columns = ReadData("Введите число столбцов: ");
//fill 2D array with random values
int[,] array = FillArrayRandom(rows, columns);
//print array
PrintArray(array);
//print means for each column
PrintMeans(CalculateMean(array));
//print mean for diagonal if possible
PrintArrayDiagonal(array, CalculateMeanDiagonal(array));

//ReadData method requests user to insert data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//FillArrayRanom fills 2D array with random integer
int[,] FillArrayRandom(int rows, int columns)
{
    //create new array as per inserted parameters
    int[,] array = new int[rows, columns];
    //cycle of filling array
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new System.Random().Next(1, 10);
        }
    }
    return array;
}

//CalculateMean method calculates mean for every column
double[] CalculateMean(int[,] array)
{
    //create array to store sum of elements in column
    double[] columnSum = new double[array.GetLength(1)];
    //cycle of sum calculation
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            columnSum[j] = columnSum[j] + array[i, j]; 
        }
    }
    //create array to store calculated means
    double[] means = new double[array.GetLength(1)];
    //cycle of means calculation for each column
    for(int k = 0; k < array.GetLength(1); k++)
    {
        means[k] = columnSum[k] / array.GetLength(0);
    }
    return means;
}

//CalculateMeanDiagonal calculates mean for matrix diagonal if possible
double CalculateMeanDiagonal(int[,] array)
{
    //create variable to store mean
    double diagonalMean = 0;
    //create variable to store sum of elements in diagonal
    double diagonalSum = 0;
    //check if it is possible to calculate diagonal (number of rows must be equal to number of columns)
    if(array.GetLength(0) == array.GetLength(1))
    {
        //sum calculation cycle
        for(int i = 0; i < array.GetLength(0); i++)
        {
            diagonalSum = diagonalSum + array[i, i];
        }
        //calculate mean
        diagonalMean = diagonalSum / array.GetLength(0);
    }
    else
    {
        //if mean cannot be calculated we assign zero
        diagonalMean = 0;
    }
    return diagonalMean;
}

//PrintArray method for pint out array
void PrintArray(int[,] array)
{
    //cycle of array printing
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  {0}   ", array[i, j]);
        }
        Console.WriteLine();
    }
}

//PrintArrayDiagonal prints arra with highlighted diagonal if possible
void PrintArrayDiagonal(int[,] array, double diagonalMean)
{
    //if array does not have diagonal user will be notified
    if(diagonalMean == 0)
    {
        //user notification message
        Console.WriteLine("Матрица не является квадратной, нельзя посчитать среднее арифимитическое элементов на диагонали!");
    }
    else
    {
        //print mean of elements on diagonal
        Console.WriteLine("Среднее арифметическое элементов матрицы по диагонали равно:" + " {0:N2}",diagonalMean);
        //cycle for array printing
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                //for elements on diagonal change color to yellow
                if(i==j)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("  {0}   ", array[i, j]);
                    Console.ResetColor(); 
                    
                }
                //other elements print in white
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

//PrintMeans method prints means for columns
void PrintMeans(double[] means)
{
    Console.WriteLine("Средние арифметические элементов столбцов равны:");
    //print means cycle
    for(int i = 0; i < means.Length; i++)
    {
        Console.Write(" {0:N2} ", means[i]);
    }
    Console.WriteLine();
}