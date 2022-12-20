//collect number of elements in array
int number = ReadData("Введите число элементов массива:");
//collect minimum array element value
int min = ReadData("Введите минимальное значение элемента массива:");
//collect maximum array element value
int max = ReadData("Введите максимальное значение элемента массива:");
//generate array based on given conditions
int[] arrayInitial = GenerateArray(number, min, max);
//output of generated array
PrintArray("В заданном массиве:", arrayInitial);
//output of odd elements sum
PrintResultOddSum("Сумма нечетных элементов массива равна: ", OddSumCount(arrayInitial));

//ReadData method - collect input data
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//GenerateArray method creates new array based on given conditions
int[] GenerateArray(int length, int min, int max)
{
    //create new array
    int[] array = new int[length];
    //fill in new array with element values
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

//OdsSumCount method calculates sum of array elements with odd indexes
int OddSumCount(int[] array)
{
    //create variable to store sum value
    int sum = 0;
    //launch cycle of sum calculation, start from 0 index which correspond first element
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

//PrintArray method used to represent array as a string
void PrintArray(string message, int[] array)
{
    //define number of elements in array
    int length = array.Length;
    //create new string
    string arrayLine = string.Empty;
    //build string by adding array element on each step
    for (int i = 0; i < length; i++)
    {
        arrayLine = arrayLine + array[i] + " ";
    }
    //output string
    Console.WriteLine(message);
    //output string containing array
    Console.WriteLine(arrayLine);
}

//PrintResultOddSum used for output dum of elements wit odd indexes
void PrintResultOddSum(string message, int sum)
{
    Console.WriteLine(message + sum);
}