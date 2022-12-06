int Number = int.Parse(Console.ReadLine()??"0");

int result1 = Number%7;
int result2 = Number%23;

if(result1==0 && result2==0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}