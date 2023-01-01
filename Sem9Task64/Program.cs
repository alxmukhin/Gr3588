//get value of N
int number = ReadData("Введите число N:");
//create string of values from N to 1 and print it
PrintResult("Последовательность натуральных чисел от N до 1: ", RecursionDecrease(number));

//ReadData method requests user to insert data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//RecursionDecrease method creates string of values from number to 1
string RecursionDecrease(int number)
{
    //condition for stop of recusion
    if(number <= 0)
    {
        return string.Empty;
    }
    //use recursion to creates string
    else
    {
        string result = number + " " + RecursionDecrease(number - 1);
        return result;
    }
}

//PrintResult method prints string created by recursion with explanation message prior to it
void PrintResult(string message, string result)
{
    Console.WriteLine(message + result);
}