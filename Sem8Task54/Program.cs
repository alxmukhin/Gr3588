//get number of rows
int rows = ReadData("Введите число строк: ");
//get number of columns
int columns = ReadData("Введите число столбцов: ");
//fill 2D array with random values
int[,] array = FillArrayRandom(rows, columns);
//print initial array
PrintArray("Массив с заданными параметрами:", array);
//print sorted array
PrintArray("Массив с элементами отсортированными в строках по убыванию:", SortArrayDecrease(array));


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

//SortArrayDecrease method decrerase sorting elements in a row
int[,] SortArrayDecrease(int[,] array)
{
    //switch from row to row
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        //decrease sort cycle in a row
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if(array[i, k + 1] > array[i, k])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i,  k+ 1] = temp;
                }
            }
        }
    }
    return array;
}