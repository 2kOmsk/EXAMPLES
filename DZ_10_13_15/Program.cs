// Задание 10
Console.WriteLine("Введите число : ");
string num = Console.ReadLine();
Console.WriteLine(num[1]);

// Задание 13
Console.WriteLine("Введите число от 3-х символов: ");
string nuM = Console.ReadLine();
int lenght = Convert.ToInt32(nuM.Length);
int index = 3;
if (lenght < index )
{
    Console.WriteLine("вы ввели число менее 3-х символов");
}
else
{
    Console.WriteLine(nuM[2]);
};

// Задание 15
Console.WriteLine("Введите число обозначающее день недели: ");
string userday = Console.ReadLine();
int findday = Convert.ToInt32(userday);
int [] week = {1,2,3,4,5};
int days = week.Length;
{
    if (findday <= days)
    {
        Console.WriteLine("Рабочийдень");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
};