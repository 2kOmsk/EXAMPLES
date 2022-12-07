Console.WriteLine("Введите число обозначающее день недели: ");
string userday = Console.ReadLine();
int findday = Convert.ToInt32(userday);
int [] week = {1,2,3,4,5};
int days = week.Length;
int index = 4;
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



//int [] rab = new int {1,2,3,4,5};
//int [] vix = new int {6,7};
