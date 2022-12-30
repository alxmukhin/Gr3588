//get number of elements in first dimension
int x = ReadData("Введите число элементов первого измерения массива: ");
//get number of elements in second dimension
int y = ReadData("Введите число элементов второго измерения массива: ");
//get number of elements in third dimension
int z = ReadData("Введите число элементов третьего измерения массива: ");
//create list of two digit numbers
List<int> numbers = new List<int>();
for(int i = 0; i < 90; i++)
{
    numbers.Add(10+i);
}
//print result
Print3DArray(Fill3DArray(x, y, z));

//ReadData method requests user to insert data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//UniqueNumberGenerator method generate unique two digit number
int UniqueNumGenerator (List<int> numbers)
{
    int index = new Random().Next(0, numbers.Count);
    int outnumber = numbers[index];
    numbers.RemoveAt(index);
    return outnumber;
}

//Fill3DArray method fills in 3D array with unique two digit numbers
int[,,] Fill3DArray(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                array3D[i, j, k] = UniqueNumGenerator(numbers);
            }
        }
    }
    return array3D;
}

//Print3DArray method print 3D array with element 
void Print3DArray(int[,,] array3D)
{
     for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                Console.Write(array3D[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
}