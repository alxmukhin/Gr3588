
int number = ReadNumber("Введите число:");
DateTime d1 = DateTime.Now;
PrintResult("Cумма цифр в данном числе равна: ", SumCalculationString(number));
Console.WriteLine("Время подсчета методом преобразования в строку равно: " + (DateTime.Now-d1));

DateTime d2 = DateTime.Now;
PrintResult("Cумма цифр в данном числе равна: ", SumCalculatorNumber(number));
Console.WriteLine("Время подсчета методом логарифма равно: " + (DateTime.Now-d2));

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int SumCalculationString(int number)
{
    char[] digits = number.ToString().ToCharArray();
    int length = number.ToString().Length;
    int result = 0;
    int i=0;
    while(i<length)
    {
        int digit = 0;
        digit = digits[i] - '0';
        result = result + digit;
        i++;
    }
    return result;
}

int SumCalculatorNumber(int number)
{
    int length = (int)Math.Log10(number);
    int i = 0;
    int result = 0;
    while(i <= length)
    {
        int digit = number%10;
        number = number/10;
        result = result + digit;
        i++;
    }
    return result;
}

void PrintResult(string message, int result)
{
    Console.WriteLine(message + result);
}