//Get quantity of numbers which will be inserted
int number = ReadData("Введите количество чисел: ");
//Print quantity of munbers greater than zero
PrintResult("Количество чисел больше нуля среди введенных: ", CountPositive(number));

//ReadData method requests user to input data and collects it
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//CountPositive method counts quantity numbers avove zero inserted by user
int CountPositive (int number)
{
    int i = 0;
    //Create variable to store result of counting
    int counter = 0;
    //Counting cycle based on value inserted by user
    while (i < number)
    {
        //Collect number
        int inputNumber = ReadData("Введите число " + (i + 1) + ": ");
        //Make number assessment
        if (inputNumber > 0)
        {
            //Count value if it is greater than zero
            counter = counter + 1;
        }
        i++;
    }
    //Method output is counted number
    return counter;
}

//PrintResult method outputs result with certain message
void PrintResult(string message, int number)
{
    Console.WriteLine(message + number);
}