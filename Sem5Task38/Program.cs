//collect number of elements in array
int number = ReadData("Введите число элементов массива:");
//generate array of double based on given conditions
double[] arrayInitial = GenerateDoubleArray(number);
//output of generated array
PrintArray("В заданном массиве:", arrayInitial);
//output difference between max and min elements
PrintResultDiffMaxMin("Разница между максимальным и минимальным элементами равна: ", MaxMinDiff(arrayInitial));

//ReadData method - collect input data
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//GenerateArray method creates new double array based on given conditions
double[] GenerateDoubleArray(int length)
{
     //create new array
    double[] array = new double[length];
    //fill in new array with element values from 0 to 1
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.NextDouble();
    }
    return array;
}

//MaxMinDiff calculated difference between max and min elements value
double MaxMinDiff(double[] array)
{
    //assign max value for search
    double max = double.MinValue;
    //assign min value for search
    double min = double.MaxValue;
    //cycle for search max and min values
    for (int i = 0; i < array.Length; i++)
    {
        //condition for max value
        if (max < array[i])
        {
            max = array[i];
        }
        //condition for min value
        if (min > array[i])
        {
            min = array[i];
        }
    }
    //calculate difference between min and max
    double diff = max - min;
    return diff;
}

//PrintArray method used to represent array as a string
void PrintArray(string message, double[] array)
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

//PrintResultDiffMaxMin method prints difference between min and max elements
void PrintResultDiffMaxMin(string message, double diff)
{
    Console.WriteLine(message + diff);
}