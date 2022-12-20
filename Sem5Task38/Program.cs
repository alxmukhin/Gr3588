int number = ReadData("Введите число элементов массива:");
double[] arrayInitial = GenerateDoubleArray(number);
PrintArray("В заданном массиве:", arrayInitial);
PrintResultEven("Разница между максимальным и минимальным элементами равна: ", MaxMinDiff(arrayInitial));

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[] GenerateDoubleArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.NextDouble();
    }
    return array;
}

double MaxMinDiff(double[] array)
{
    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine(min);
    Console.WriteLine(max);
    double diff = max - min;
    return diff;
}

void PrintArray(string message, double[] array)
{
    int length = array.Length;
    string arrayLine = string.Empty;
    for (int i = 0; i < length; i++)
    {
        arrayLine = arrayLine + array[i] + " ";
    }
    Console.WriteLine(message);
    Console.WriteLine(arrayLine);
}

void PrintResultEven(string message, double diff)
{
    Console.WriteLine(message + diff);
}