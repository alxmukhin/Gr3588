int number = ReasData("Введите число N:");
PrintResult("Последовательность натуральных чисел от N до 1: ", RecursionDecrease(number));

int ReasData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

string RecursionDecrease(int number)
{
    if(number <= 0)
    {
        return string.Empty;
    }
    else
    {
        string result = number + " " + RecursionDecrease(number - 1);
        return result;
    }
}

void PrintResult(string message, string result)
{
    Console.WriteLine(message + result);
}