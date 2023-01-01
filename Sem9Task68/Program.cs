//get parameter "m" for Ackermann function
int m = ReasData("Введите параметр m функции Аккермана:");
//get parameter "n" for Ackermann function
int n = ReasData("Введите параметр n функции Аккермана:");
//calculate value of Ackermann function for given parameters and print it
PrintResult("Значение функции Аккермана для заданных параметров равно: ", RecursionAckermann(m, n));

//ReadData method requests user to insert data and collects it
int ReasData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//RecursionAckerman method receives "m" and "n" parameters and calculate value of Ackermann function for them
int RecursionAckermann(int m, int n)
{
    //calculation of Ackermann function based on its definition
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

//PrintResult method prints value of Ackermann function calculated by recursion with explanation message prior to it
void PrintResult(string message, int ackerman)
{
    Console.WriteLine(message + ackerman);
}