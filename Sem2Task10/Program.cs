Console.WriteLine("Введите трехзначное число:");
// read number string & convert to integer & null safety check
int numberN = int.Parse(Console.ReadLine()??"0");
//create variable to store result
int result;
//check if read number consists of three digits
if(numberN>99 && numberN<1000)
{
    //extract second and third digits
    result = numberN%100;
    //extract second digit
    result = result/10;
    //output result
    Console.WriteLine("Вторая цифра в данном числе: " + result);
}
else
{
    //output if read number does not consist of three digits
    Console.WriteLine("Введенное число не является трехзначным! ");
}