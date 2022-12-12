int number = ReadData("Введите пятизначное число:");
PrintData(number, PolyndromTest(number));

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

bool PolyndromTest (int number)
{
    bool testResult = false;
    if(number%10 == number/10000 && number%100/10 == number/1000%10)
    {
        testResult = true;
    }
    else
    {
        testResult = false;
    }
    return testResult;
}
void PrintData (int number, bool testResult)
{
    if(Math.Log10(number)>3 && Math.Log10(number)<5)
    {
        if(testResult == true)
        {
            Console.WriteLine("Данное число является полиндромом.");
        }
        else
        {
            Console.WriteLine("Данное число не является полиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Введенное число не является пятизначным!");
    }
}