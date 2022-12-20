//Collect number ofelements in array
int number = ReadData("Введите число элементов массива:");
//generate new array
int[] arrayInitial = GenerateArray(number);
//print array
PrintArray("В заданном массиве:", arrayInitial);
//count number of even elements in array and output
PrintResultEvenCount("Количество четных элементов массива равно: ", EvenCount(arrayInitial));
// apply bubble sort
int[] arraySorted = BubbleSort(arrayInitial);
// print sorted array
PrintArray("Массив отсортированный по возрастанию:", arrayInitial);

//ReadData method - input number of elements
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//GenerateArray method generates array of random integer between 100 and 999, based on inserted number of lements 
int[] GenerateArray(int length)
{
    //create new array
    int[] array = new int[length];
    //fill in array with random values based on conditions
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

//EvenCount method counts number of even array elements
int EvenCount(int[] array)
{
    //define counter initial value
    int count = 0;
    //start counting
    for (int i = 0; i < array.Length; i++)
    {
        //condition for counter
        if(array[i]%2 == 0) 
        {
            count = count + 1;
        }
    }
    return count;
}

//BubleSort method sorts array from min to max, defining max element in each cycle
int[] BubbleSort(int[] array)
{
    //start cycle
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
    return array;
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

//PrintResultEvenCount used for outpiut result for number of even elements
void PrintResultEvenCount(string message, int count)
{
    Console.WriteLine(message + count);
}