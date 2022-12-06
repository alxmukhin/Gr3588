//Создаем экземпляр класса рандомайзера
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(100,1000);

Console.WriteLine(number);

int result = ((number/100)*10 + number%10);
Console.WriteLine(result);