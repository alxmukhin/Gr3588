//get number of rows
int rows = ReadData("Введите число строк: ");
//get number of columns
int columns = ReadData("Введите число столбцов: ");
//fill 2D array with random values
int[,] array = FillArrayRandom(rows, columns);
//print initial array
PrintArray("Массив с заданными параметрами:", array);
PrintResults(FindMinimalSumRow(array));


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

//FindMimimalSumRow method finds row/rows with minimal sum
int[] FindMinimalSumRow(int[,] array)
{
    int[]sumArray = new int[array.GetLength(0)];
    int[]sumArraySorted = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] = sumArray[i] + array[i, j];
            sumArraySorted[i] = sumArraySorted[i] + array[i, j];
        }
    }

    for(int m = 0; m < sumArraySorted.Length - 1; m++)
    {
        for(int n = 0; n < sumArraySorted.Length - m - 1; n++)
        {
            if(sumArraySorted[n] > sumArraySorted[n + 1])
            {
                int temp = sumArraySorted[n + 1];
                sumArraySorted[n + 1] = sumArraySorted[n];
                sumArraySorted[n] = temp;
            }
        }
    }

    int minSum = sumArraySorted[0];
    int quantityMin = 0;

    for(int k = 0; k < sumArray.Length; k++)
    {
        if(sumArray[k] == minSum)
        {
            quantityMin++;
        }
    }

    int[] minRowNumbers = new int[quantityMin];
    int diff = 0;
    for(int l = 0; l < sumArray.Length; l++)
    {
        if(sumArray[l] == minSum)
        {
            minRowNumbers[l - diff] = l + 1;
        }
        else
        {
            diff++;
        }
    }
    return minRowNumbers;
}

void PrintResults(int[] minRowNumbers)
{
    if(minRowNumbers.Length == 1)
    {
        Console.WriteLine("Минимальная сумма элементов в строке " + minRowNumbers[0]);
    }
    else
    {
        Console.Write("Минимальная сумма элементов в строках ");
        for(int i = 0; i < minRowNumbers.Length; i++)
        {
            Console.Write(minRowNumbers[i] + " ");
        }
    }
}