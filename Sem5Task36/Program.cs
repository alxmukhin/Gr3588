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
//output number of repeated elements
CountRepeatedElements(arrayInitial);

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

//CountRepeatedElements method count number of array elements with same value
void CountRepeatedElements(int[] array)
{
    //sort array from min to max
    for (int i = 0; i < array.Length - 1; i++)
    {
        //reduce array by one element when max is found
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            {
                //condition of defining max element
                if (array[j] > array[j+1])
                {
                    int temp = array[j+1];
                    array[j+1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    int x = 0;
    //start counting cycle
    while (x < array.Length)
    {
        //set conter value
        int counter = 0;
        //set reference value for comparison
        int reference = array[x];
        //pass through array to find number of identical values
        for (int y = x; y < array.Length; y++)
        {
            //comparison of value with reference
            if (array[y] == reference)
            {
                //counter
                counter = counter + 1;
                //since array is sorted and next value is identical it will be skipped by the cycle
                x++;
            }
        }
        Console.WriteLine("Значение " + reference + " имеют " + counter + " элементов в массиве.");
    }
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

//PrintResultOddSum used for output dum of elements with odd indexes
void PrintResultOddSum(string message, int sum)
{
    Console.WriteLine(message + sum);
}