//read data
int number = ReadNumber("Введите число:");
DateTime d1 = DateTime.Now;
//print result for 1st method
PrintResult("Cумма цифр в данном числе равна: ", SumCalculationString(number));
//print time required for calculation for 1st method
Console.WriteLine("Время подсчета методом преобразования в строку равно: " + (DateTime.Now-d1));

DateTime d2 = DateTime.Now;
//print result for 2nd method
PrintResult("Cумма цифр в данном числе равна: ", SumCalculatorNumber(number));
//print time required for calculation for 1st method
Console.WriteLine("Время подсчета методом логарифма равно: " + (DateTime.Now-d2));

//ReadNumber method, return integer number
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//SumCalculationString method calculates sum of digits based on conversion into array
int SumCalculationString(int number)
{
    //convert number to array
    char[] digits = number.ToString().ToCharArray();
    //count array lenght
    int length = number.ToString().Length;
    //assign variable to store result
    int result = 0;
    int i=0;
    //calculate sum of digits in number
    while(i<length)
    {
        int digit = 0;
        digit = digits[i] - '0';
        result = result + digit;
        i++;
    }
    return result;
}

//SumCalculatorNumber method calculated sum of digits based on separation of digits based on logarithm
int SumCalculatorNumber(int number)
{
    //find number of digits in number
    int length = (int)Math.Log10(number);
    int i = 0;
    //assign variable to store result
    int result = 0;
    //calculate sum of digits in number
    while(i <= length)
    {
        int digit = number%10;
        number = number/10;
        result = result + digit;
        i++;
    }
    return result;
}

//PrintResut outputs result
void PrintResult(string message, int result)
{
    Console.WriteLine(message + result);
}