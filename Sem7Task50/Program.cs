//get number of rows
int rows = ReadData("Введите число строк: ");
//get number of columns
int columns = ReadData("Введите число столбцов: ");
//create new array filled in with Fibonacci numbers
int[,] arrayFibonacci = FillArrayFibonacci(rows, columns);
//get row number of searched elemnet
int rowNumber = ReadData("Введите номер строки искомого элемента: ");
//get column number of searched element
int columnNumber = ReadData("Введите номер столбца искомого элемента: ");
//print value of element which corresponds inserted parameters
PrintSearchResult(ElementSearch(arrayFibonacci, rowNumber, columnNumber));
//print array and highlight searched element
PrintArrayFibonacci(arrayFibonacci, rowNumber, columnNumber);

//ReadData method requests user to insert data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//FillArrayFibonacci method generates needed quantity of Fibonacci numbers and them records them as 2D array elements
int[,] FillArrayFibonacci(int rows, int columns)
{
    //calculate quantity number of Fibonacci numbers
    int number = rows * columns;
    //create array to store Fibonacci numbers
    int[] numbersFibonacci = new int[number];
    //insert first two Fibonacci mumbers as first two aray elements, they will be needed for calculation of next elements
    numbersFibonacci[0] = 0;
    numbersFibonacci[1] = 1;
    //calculation of Fibonacci numbers, starts from third, as first two needed for calculation logic
    for(int k = 2; k < number; k++)
    {
       //next Fibonacci number is sum of its two ancestors
       numbersFibonacci[k] = numbersFibonacci[k-2] + numbersFibonacci[k-1];
    }
    
    //create new 2D array to fill in with calculated Fibonacci numbers
    int[,] array = new int[rows, columns]; 
    int n = 0;
    //fill in array with Fibonacci numbers
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

//ElementSearch method searches value of element for which are known its row and column numbers
int[] ElementSearch(int[,] array, int rowNumber, int columnNumber)
{
    //create new variable to store search results
    int[] result = new int[2];
    result[0] = 1;
    //check if inserted row and column numbers corresponds array
    if(rowNumber > array.GetLength(0) || columnNumber > array.GetLength(1))
    {
        result[0] = 0;
    }
    //if inserted parameters correspond 2D array record its value
    else
    {
        result[1] = array[rowNumber - 1, columnNumber - 1];
    }
    return result;
}

//PrintArrayFibonacci prints array filled with Fibonacci numbers and highlights searched element
void PrintArrayFibonacci(int[,] array, int rowNumber, int columnNumber)
{
    //start printing
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            //if element row and column numbers corresponds to parameters inserted by the user color changes to red
            if(i == rowNumber - 1 && j == columnNumber - 1)
            {  
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}  ", array[i, j]);
                Console.ResetColor();
            }
            //other values printed in white color
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

//PrintSearchResult method used to print results of search
void PrintSearchResult(int[] result)
{
    //if array does not contain element with inserted parameters user gets notified
    if(result[0] == 0)
    {
        Console.WriteLine("В массиве нет элемента с такими параметрами!");
    }
    //if element value found it will be represented with explanation
    else
    {
         Console.WriteLine("Значение искомого элемента равно: " + result[1]);
    }
}