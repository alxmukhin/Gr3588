//get number of rows in 2D array
int rows = ReadData("Введите число строк: ");
//get number of columns in 2D array
int columns = ReadData("Введите число столбцов: ");
//generate and print out array filled with double elements
PrintArray(FillArrayRandom(rows, columns));

//ReadData method requests user to insert data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//FillArrayRandom method fills 2D array with defined number of elements in rows and columns with double values
double[,] FillArrayRandom(int rows, int columns)
{
    //create new 2D array with certain number of rows and columns
    double[,] array = new double[rows, columns];
    //cycle fills in 2D array with random double values
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            //generation of random double value, multiplied on 100 as generator makes values from 0 to 1
            array[i, j] = new System.Random().NextDouble() * 100;
        }
    }
    return array;
}

//PrintArray method prints array with each element colored in random color
void PrintArray(double[,] array)
{
    Console.WriteLine("Массив с заданными параметрами:");
    //create color options choise
    ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    //printing array
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            //randomly change console color
            Console.ForegroundColor = colors[new System.Random().Next(0, 16)];
            //print array element
            Console.Write("{0:N2}  ", array[i, j]);
        }
        Console.WriteLine();
    }
}