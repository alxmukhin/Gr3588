void TestSQRT(int i, int j)
{
    bool result = (i/j==j);
    if(result==true) Console.WriteLine("Число " + i + " является квадратом числа " + j);
    else Console.WriteLine("Число " + i + " не является квадратом числа " + j);
}

int NumberA = int.Parse(Console.ReadLine()??"0");
int NumberB = int.Parse(Console.ReadLine()??"0");
TestSQRT(NumberA, NumberB);
TestSQRT(NumberB, NumberA);