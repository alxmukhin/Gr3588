int number = ReadData("Введите количество чисел: ");
PrintResult("Количество чисел больше нуля среди введенных: ", CountPositive(number));


//ReadData method requests user to input data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//CountPositive method counts nquantity of positive values inserted by user
int CountPositive (int number)
{
    int i = 0;
    //crreate variable to store result of counting
    int counter = 0;
    //laubch counting cycle based on value inserted by user
    while (i < number)
    {
        int inputNumber = ReadData("Введите число " + (i + 1) + ": ");
        if (inputNumber > 0)
        {
            counter = counter + 1;
        }
        i++;
    }
    return counter;
}

//PrintResult method outputs result with certain message
void PrintResult(string message, int number)
{
    Console.WriteLine(message + number);
}