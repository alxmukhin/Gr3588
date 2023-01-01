int numberM = ReasData("Введите число M:");
int numberN = ReasData("Введите число N:");
PrintResult("Сумма чисел от M до N равна: ", RecursionSum(numberM, numberN));

int ReasData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecursionSum(int numberM, int numberN)
{
    if(numberM >= numberN)
    {
        return numberM;
    }
    else
    {
        return numberM + RecursionSum(numberM + 1, numberN);
    }
}

void PrintResult(string message, int sum)
{
    Console.WriteLine(message + sum);
}