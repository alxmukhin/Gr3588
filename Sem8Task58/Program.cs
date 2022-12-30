//get number of rows in first matrix
int rowsMatrix1 = ReadData("Введите число строк первой матрицы: ");
//get number of columns in first matrix
int columnsMatrix1 = ReadData("Введите число столбцов первой матрицы: ");
//get number of rows in second matrix
int rowsMatrix2 = ReadData("Введите число строк второй матрицы: ");
//get number of columns in second matrix
int columnsMatrix2 = ReadData("Введите число столбцов второй матрицы: ");
//fill first matrix with random values
int[,] matrix1 = FillArrayRandom(rowsMatrix1, columnsMatrix1);
//fill second matrix with random values
int[,] matrix2 = FillArrayRandom(rowsMatrix2, columnsMatrix2);
//print first matrix
PrintArray("Первая матрица:", matrix1);
//print second matrix
PrintArray("Вторая матрица:", matrix2);
//check if multiplication ispossible
if(columnsMatrix1 == rowsMatrix2)
{
    //print result of multiplication
    PrintArray("Произведение двух матриц:", MatrixMultiplication(matrix1, matrix2));
}
else
{
    Console.WriteLine("Матрицы несогласованы, число столбцов первой не равно числу строк второй, невозможно вычислить их произведение!");
}



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

//PrintArray method for pint out array
void PrintArray(string message, int[,] array)
{
    Console.WriteLine(message);
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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix12 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
                int sum = 0;
                for(int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum = sum + matrix1[i, k] * matrix2[k, j];
                }
                matrix12[i, j] = sum;
        }
    }
    return matrix12;
}