//get value of number M
int numberM = ReasData("Введите число M:");
//get value of number N
int numberN = ReasData("Введите число N:");
//calculate sum of numbers between M and N
PrintResult("Сумма чисел от M до N равна: ", RecursionSum(numberM, numberN));

//ReadData method requests user to insert data and collects it
int ReasData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//RecursionSum method calculates sum of elements between numbers M and N
int RecursionSum(int numberM, int numberN)
{
    //change M and N numbers in case if user inserted M bigger than N
    if(numberN < numberM)
    {
        int temp = numberM;
        numberM = numberN;
        numberN = temp;
    }
    
    //condition for stop of recursion
    if(numberM >= numberN)
    {
        return numberM;
    }
    //calculate sum of elements with recusion
    else
    {
        return numberM + RecursionSum(numberM + 1, numberN);
    }
}

//PrintResult method prints sum of numbers calculated by recursion with explanation message prior to it
void PrintResult(string message, int sum)
{
    Console.WriteLine(message + sum);
}