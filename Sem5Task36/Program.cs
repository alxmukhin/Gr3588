int number = ReadData("Введите число элементов массива:");
int min = ReadData("Введите минимальное значение элемента массива:");
int max = ReadData("Введите максимальное значение элемента массива:");
int[] arrayInitial = GenerateArray(number, min, max);
PrintArray("В массиве:", arrayInitial);
PrintResultEven("Сумма нечетных элементов массива равна: ", OddSumCount(arrayInitial));

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenerateArray(int length, int min, int max)
{
    int[] outArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        int randnum = rnd.Next(min, max + 1);
        outArray[i] = randnum;
    }
    return outArray;
}

int OddSumCount(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(string message, int[] array)
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

void PrintResultEven(string message, int number)
{
    Console.WriteLine(message + number);
}