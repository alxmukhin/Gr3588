//collect string with names separated by comma
string line = ReadLine("Введите перечень имен, разделяя их запятой:");
//print randomly picked name
PrintResult("Случайное имя из данного перечня: ", RandomName(line));

//ReadLine method for data input return string containing names
string ReadLine(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? "0";
}

//RandomName method randomly picks one name out of the line names separated by comma, return string
string RandomName(string line)
{
    //split line into array
    string[] names = line.Split(',');
    //count number of elements in array
    int lenght = names.Length;
    //generate random number of array element
    Random rnd = new Random();
    int randnum = rnd.Next(0, lenght+1);
    //record name which corresponds randomly picked number
    string randname = names[randnum];
    return randname;
}

//PrintResult method outputs random name
void PrintResult(string message, string randname)
{
    Console.WriteLine(message + randname);
}