int m = ReasData("Введите аргумент m функции Аккермана:");
int n = ReasData("Введите аргумент n функции Аккермана:");
PrintResult("Значение функции Аккермана: ", RecursionAckermann(m, n));

int ReasData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecursionAckermann(int m, int n)
{
    if(m > 0)
    {
        if(n > 0)
        {
            return RecursionAckermann(m - 1, RecursionAckermann(m, n - 1));
        }
        else
        {
            return RecursionAckermann(m - 1, 1);
        }
    }
    else
    {
        return n + 1;
    }

}

void PrintResult(string message, int ackerman)
{
    Console.WriteLine(message + ackerman);
}