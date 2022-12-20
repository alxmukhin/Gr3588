int number = ReadData("Введите число элементов массива:");
int[] arrayInitial = GenerateArray(number);
PrintArray("В массиве:", arrayInitial);
PrintResultEven("Количество чётных элементов в данном массиве равно: ", EvenTestCount(arrayInitial));
int[] arraySorted = BubbleSort(arrayInitial);
PrintArray ("Массив отсортированный по возрастанию элементов:", arraySorted);

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenerateArray(int length)
{
    int[] outArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        int randnum = rnd.Next(100, 1000);
        outArray[i] = randnum;
    }
    return outArray;
}

int EvenTestCount(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) counter = counter + 1;
    }
    return counter;
}

int[] BubbleSort (int[] array)
{
    for (int i = 0; i < (array.Length - 1); i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j+1])
            {
                int temp = array[j+1];
                array[j+1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
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