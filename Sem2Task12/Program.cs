int NumberA = int.Parse(Console.ReadLine()??"0");
int NumberB = int.Parse(Console.ReadLine()??"0");

int rest = NumberB%NumberA;

if(rest==0)
{
    Console.WriteLine("Является кратным");
}
else
{
    Console.WriteLine("Не вляется кратным");
}